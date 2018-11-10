﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AptitudeTestOnline.Models
{
    [Table("TypeOfQuestions")]
    public class TypeOfQuestionModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int TypeOfQuestion { get; set; }
        public string NameTypeOfQuestion { get; set; }
    }
}