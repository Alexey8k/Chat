﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLevel.ChatServiceReference;
using LogicLevel.Mapping;
using LogicLevel.Model;

namespace LogicLevel
{
    public class AuthorizationManager
    {
        private readonly ChatTransport _chatTransport;
        private readonly IHashAlgorithm _hashAlgorithm;
        public AuthorizationManager(ChatTransport chatTransport, IHashAlgorithm hashAlgorithm)
        {
            _chatTransport = chatTransport;
            _hashAlgorithm = hashAlgorithm;
        }
        public LoginResultModel Login(LoginModel obj)
        {
            return _chatTransport.Login(obj.Mapping(_hashAlgorithm)).Mapping<LoginResultModel>();
        }

        public void Logout(LogoutModel obj)
        {
            _chatTransport.Logout(obj.Mapping<LogoutTransportModel>());
        }

        public RegistrationResultModel Registration(RegistrationModel obj)
        {
            return _chatTransport.Registration(obj.Mapping(_hashAlgorithm)).Mapping<RegistrationResultModel>();
        }
    }
}
