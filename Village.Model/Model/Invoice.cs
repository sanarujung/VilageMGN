﻿using System;

namespace Village.Model.Model
{
    public class Invoice
    {
        public Invoice()
        {

        }

        public int OwnerId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}