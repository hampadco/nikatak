using System;
using System.ComponentModel.DataAnnotations;
namespace ViewModels.AdminViewModel.Wallet
{
    public class Vm_Pay
    {

        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Pay { get; set; }
        public int Harvest { get; set; }
        public string DateTime { get; set; }
        public bool status { get; set; }
        public int RequestId { get; set; }

    }
}