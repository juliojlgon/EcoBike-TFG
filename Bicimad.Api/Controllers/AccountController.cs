﻿using System.Linq;
using System.Web.Http;
using Bicimad.Api.Attributes;
using Bicimad.Api.Models.Account;
using Bicimad.Helpers;
using Bicimad.Services.Command.Commands.User;
using Bicimad.Services.Command.Interface;
using Bicimad.Services.Query.Dto.User;
using Bicimad.Services.Query.Interfaces;

namespace Bicimad.Api.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IUserCommandService _userCommandService;
        private readonly ISecurityQueryService _securityQueryService;
        private readonly IUserQueryService _userQueryService;


        public AccountController(IUserQueryService userQueryService, IUserCommandService userCommandService, ISecurityQueryService securityQueryService)
        {
            _userQueryService = userQueryService;
            _userCommandService = userCommandService;
            _securityQueryService = securityQueryService;
        }

        // POST: api/login
        [HttpPost]
        public virtual IHttpActionResult Login(string username, string password)
        {
            var model = new LoginModel
            {
                Password = password,
                RememberMe = false,
                UserNameOrEmail = username
            };
            if (ModelState.IsValid)
            {
                UserLoginDto userDto;
                var loginResult = _userQueryService.TryLogin(model.UserNameOrEmail, model.Password, out userDto);
                if (loginResult)
                {
                    var token = LogUser(userDto, password, model.RememberMe);
                    _securityQueryService.IsTokenValid(token);

                    return Json(new { Success = true, Token = token , CurrentUser});
                }
            }

            return Json(new { Success = false, Token = "" });
        }

        [ApiAuthorize, HttpPost]
        public virtual IHttpActionResult GetUserData()
        {
            return Json(new {CurrentUser});
        }


        private string LogUser(UserLoginDto userDto, string password, bool remember)
        {
            CurrentUser = new UserLoggedModel
            {
                Id = userDto.Id,
                Email = userDto.Email,
                Avatar = userDto.Avatar,
                Name = userDto.UserName,
                IsAdmin = userDto.IsAdmin,
                FriendlyUrlName = userDto.FriendlyUrlUserName
            };

            return HashHelper.GenerateToken(userDto.Id, userDto.UserName, password, DateTimeHelper.SpanishNow.Ticks,userDto.IsAdmin);


        }
       
        [HttpPost]
        public virtual IHttpActionResult Register(string username, string email, string password, string rePass)
        {
            var model = new RegisterModel
            {
                UserName = username,
                Password = password,
                Email = email,
                ConfirmPassword = rePass
            };
            if (!ModelState.IsValid) return Json(new {Success = false});
            var createUserResult = _userCommandService.Create(new CreateUserCommand
            {
                UserName = model.UserName,
                FriendlyUrlUserName = model.UserName.Sanitize(),
                Email = model.Email,
                Password = model.Password,
                IsActive = true
            });

            if (createUserResult.Success)
            {
                return Ok( new {Success = true, Error = ""});
            }

            return Json(new { Success = false, Error = createUserResult.ValidationErrors.Select(e => e.ErrorMessage).First()});
        }

        [HttpGet]
        public virtual IHttpActionResult IsTokenValid(string token)
        {
           var valid = _securityQueryService.IsTokenValid(token);

            return Json(new {Token = token, Valid = valid});
        }

        [ApiAuthorize]
        public virtual IHttpActionResult LogOut()
        {
            //Borrar el Token y regenerarlo en el siguiente login.
            return Ok();
        }

        /// <summary>
        ///     For valide register form.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public virtual IHttpActionResult ValidateEmailUnique(string email)
        {
            var exists = _userQueryService.ExistsEmail(email);
            return Json(!exists);
        }

        /// <summary>
        ///     For validate register Form.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public virtual IHttpActionResult ValidateUserNameUnique(string userName)
        {
            var exists = _userQueryService.ExistsUserName(userName);
            return Json(!exists);
        }
    }
}