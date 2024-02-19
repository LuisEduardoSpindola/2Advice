using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace InfraestructureLayer.Data;

public class User : IdentityUser
{
    [Required]
    [Display(Name = "Nome")]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Senha")]
    public string Password { get; set; }

    [Required]
    [Display(Name = "ADM Code")]
    public bool ADM { get; set; }

    [Required]
    [Display(Name = "Período")]
    public string Period { get; set; }

    [Required]
    [Display(Name = "Score")]
    public int Score { get; set; } = 0;
}

