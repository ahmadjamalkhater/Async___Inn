﻿namespace Async__Inn.Models.DTO
{
    public class RegisterUserDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<string> Roles { get; set; }
    }
}