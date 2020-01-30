using Models.Models;
using Models.ViewModels;
using System.Collections.Generic;

public class IndexViewModel
{
    public IEnumerable<Phone> Phones { get; set; }
    public IEnumerable<CompanyModel> Companies { get; set; }
}