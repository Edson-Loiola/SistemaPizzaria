﻿using System;

namespace SistemaWebPizzaria.Services.Exception
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {
        }
        //exception personalizada
    }
}
