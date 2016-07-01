package com.bicis_tfg.bicimad_tfg_app;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.view.inputmethod.EditorInfo;
import android.widget.AutoCompleteTextView;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;

import com.bicis_tfg.bicimad_tfg_app.helpers.ResourcesHelper;
import com.google.gson.Gson;

import javax.inject.Inject;

import butterknife.BindView;
import butterknife.ButterKnife;
import com.bicis_tfg.bicimad_tfg_app.models.LoginResult;
import com.bicis_tfg.bicimad_tfg_app.models.ValidResult;
import rx.Observable;
import rx.android.schedulers.AndroidSchedulers;
import rx.schedulers.Schedulers;
import services.IBiciMadServices;

/**
 * A login screen that offers login via email/password.
 */
public class LoginActivity extends AppCompatActivity {

    @BindView(R.id.email)
    AutoCompleteTextView mEmailView;
    @BindView(R.id.password)
    TextView mPasswordView;
    @BindView(R.id.email_sign_in_button)
    Button mEmailSignInButton;
    @BindView(R.id.email_login_form)
    LinearLayout linearLayout;

    @Inject
    SharedPreferences sharedPref;
    @Inject
    IBiciMadServices apiService;
    @Inject
    ResourcesHelper rHelper;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        // Set up the login form.
        BicimadApplication.inject(this);
        ButterKnife.bind(this);

        String token = sharedPref.getString(getResources().getString(R.string.TokenKey), "");

        Observable<ValidResult> isValid = apiService.isTokenValid(token);
        isValid.subscribeOn(Schedulers.newThread()).observeOn(AndroidSchedulers.mainThread())
                .subscribe(valid -> {

                    if (valid.getValid()) {
                        Intent intent = new Intent(getApplicationContext(), MainActivity.class);
                        startActivity(intent);
                        finish();
                    }
                },throwable -> {
                    Snackbar.make(linearLayout, "There was a network error. Try again.", Snackbar.LENGTH_LONG).setAction("Action", null).show();
                });

        mPasswordView.setOnEditorActionListener((textView, id, keyEvent) -> {
            if (id == R.id.login || id == EditorInfo.IME_NULL) {
                attemptLogin();
                return true;
            }
            return false;
        });


        mEmailSignInButton.setOnClickListener(view -> attemptLogin());


    }

    public void attemptLogin() {
        SharedPreferences.Editor editor = sharedPref.edit();
        Observable<LoginResult> result = apiService.logUser(mEmailView.getText().toString(), mPasswordView.getText().toString());


        //TODO: Devolver el usuario entero.
        result.subscribeOn(Schedulers.newThread())
                .observeOn(AndroidSchedulers.mainThread())
                .subscribe(r -> {
                    if (r.isSuccess()) {
                        editor.putString(getResources().getString(R.string.TokenKey), r.getToken());
                        editor.commit();
                        Gson gson = new Gson();
                        String json = gson.toJson(r.getCurrentUser());
                        editor.putString(rHelper.getUserKey(), json);
                        editor.commit();
                        Intent intent = new Intent(getApplicationContext(), MainActivity.class);
                        startActivity(intent);
                        finish();
                    } else {
                        Snackbar.make(linearLayout, "Something was wrong", Snackbar.LENGTH_LONG)
                                .setAction("Action", null).show();
                    }

                },throwable -> {
                    Snackbar.make(linearLayout, "There was a network error. Try again.", Snackbar.LENGTH_LONG).setAction("Action", null).show();
                });

    }


}

