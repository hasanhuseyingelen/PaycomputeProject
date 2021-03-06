﻿using Microsoft.AspNetCore.Http;
using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Paycompute.Models
{
    public class EmployeeCreateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Employee Number is required"),
            RegularExpression(@"^[A-Z]{3,3}[0-9]{3}$")]
        public string EmployeeNo { get; set; }
        [Required(ErrorMessage = "First Name is required"), StringLength(50, MinimumLength = 2),
            RegularExpression(@"^[A-Z][a-zA-Z]""'\s-]*$"), Display(Name ="Fist Name")]
        public string FirstName { get; set; }
        [StringLength(50), Display(Name ="Middle Name")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Last Name is required"), StringLength(50, MinimumLength = 2),
             RegularExpression(@"^[A-Z][a-zA-Z]""'\s-]*$"), Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string FullName { 
            get{
                return FirstName + (string.IsNullOrEmpty(MiddleName) ? " " : (" " + (char?)MiddleName[0] + ".").ToUpper()) + LastName;
            }
        }
        public string Gender { get; set; }
        [Display(Name ="Photo")]
        public IFormFile ImageUrl { get; set; }
        [DataType(DataType.Date), Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }
        [DataType(DataType.Date), Display(Name = "Date Joined")]
        public DateTime DateJoined { get; set; }
        [Required(ErrorMessage = " Job role is required"), StringLength(100)]
        public string Designation { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        // SSN 000-00-0000 
        [Required, StringLength(50), Display(Name ="NI No.")]
        [RegularExpression(@"^[A-CEGH,J-PR-TW-Z]{1}[A-CEGH,J-NPR-TW-Z]{1}[0-9]{6}[A-D\s]$")]
        public string NationalInsuranceNo { get; set; }
        [Display(Name = "Display Method")]
        public PaymentMethod PaymentMethod { get; set; }
        [Display(Name = "Student Load")]
        public StudentLoad StudentLoan { get; set; }
        [Display(Name = "Union Member")]
        public UnionMember UnionMember { get; set; }
        [Required, StringLength(150)]
        public string Address { get; set; }
        [Required, StringLength(50)]
        public string City { get; set; }
        [Required, StringLength(50), Display(Name ="Post Code")]
        public string PostCode { get; set; }
    }
}
