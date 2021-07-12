using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using Admin.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;

namespace Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class Client_CredentialController  : BaseController
    {

        public Client_CredentialController(ContextHampadco _db,IWebHostEnvironment env):base(_db,env)
      {
          
      }
        ///           انتخاب سرویس        ////////////////////////////////////////////////////
        public IActionResult Index()
        {
            return View();
        }
        ///          استعلام شماره کارت      ////////////////////////////////////////////
        public IActionResult InputCardNumber()
        {
            return View();
        }
        public IActionResult EstelamCartResult(vm_Gardesh Gardesh)
        {
            var token=db.Tbl_TokenValues.SingleOrDefault().Token;
            var client = new RestClient("https://apibeta.finnotech.ir/mpg/v2/clients/nikatak5250/cards/" + Gardesh.Deposit + "");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer"+" "+token);
            request.AddHeader("Cookie", "boomrangid=s%3A5UMXQjEUAWfS4xjbnVZ5L1RWyTHDFH0r.io8Qcr70CEa7%2FxvJWHKlogRpVsSwimeOVK1Mt0n9tu4");
            var body = @"";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var EstelamCart = JsonConvert.DeserializeObject<RootEstelamCart>(response.Content);                         
            ViewBag.Description =EstelamCart.ResultEstelamCart.Description;
            ViewBag.DestCard =EstelamCart.ResultEstelamCart.DestCard;
            ViewBag.DoTime =EstelamCart.ResultEstelamCart.DoTime;
            ViewBag.Name =EstelamCart.ResultEstelamCart.Name;
            return View();
        }
        //                کلاس های دیسریالایز استعلام شماره کارت 
        public class ResultEstelamCart
        {
            [JsonProperty("destCard")]
            public string DestCard { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("result")]
            public string Result { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("doTime")]
            public string DoTime { get; set; }
        }

        public class RootEstelamCart
        {
            [JsonProperty("trackId")]
            public string TrackId { get; set; }

            [JsonProperty("result")]
            public ResultEstelamCart ResultEstelamCart { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }
        }
        ///////////////////////////////////////////////پایان استعلام شماره کارت//////////////////////////////////////////////////////////////
        ///                    تبدیل شماره کارت به شبا     ///////////////////////////////////////////////////
        public IActionResult CartToShaba()
        {
            return View();
        }
        public IActionResult CartToShabaResult (vm_Gardesh Gardesh)
        {
            var token=db.Tbl_TokenValues.SingleOrDefault().Token;
            var client = new RestClient("https://apibeta.finnotech.ir/facility/v2/clients/nikatak5250/cardToIban?card=" + Gardesh.Deposit + "");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer"+" "+token);
            request.AddHeader("Cookie", "boomrangid=s%3AM9Y3baYsL7KiuB9HZhS8AbrqpmHz7s9R.enqYkFKYMOf73ZKw4nSMS9xLbe1HINVRTwE2cVCeZIc");
            var body = @"";
            request.AddParameter("text/plain", body,  ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var CartShaba = JsonConvert.DeserializeObject<RootCartToShaba>(response.Content);
            var s=CartShaba.ResultCartToShaba;
            ViewBag.BankName=s.BankName;
            ViewBag.Card=s.Card;
            ViewBag.Deposit=s.Deposit;
            ViewBag.DepositDescription=s.DepositDescription;
            ViewBag.IBAN=s.IBAN;
            ViewBag.Name=s.DepositOwnersCartToShaba[0].FirstName;
            ViewBag.LastName=s.DepositOwnersCartToShaba[0].LastName;

            return View();
        }
        //                کلاس های دیسریالایز استعلام شماره کارت
        public class DepositOwnerCartToShaba
        {
            [JsonProperty("firstName")]
            public string FirstName { get; set; }

            [JsonProperty("lastName")]
            public string LastName { get; set; }
        }

        public class ResultCartToShaba
        {
            [JsonProperty("IBAN")]
            public string IBAN { get; set; }

            [JsonProperty("bankName")]
            public string BankName { get; set; }

            [JsonProperty("deposit")]
            public string Deposit { get; set; }

            [JsonProperty("card")]
            public string Card { get; set; }

            [JsonProperty("depositStatus")]
            public string DepositStatus { get; set; }

            [JsonProperty("depositDescription")]
            public string DepositDescription { get; set; }

            [JsonProperty("depositComment")]
            public string DepositComment { get; set; }

            [JsonProperty("depositOwners")]
            public List<DepositOwnerCartToShaba> DepositOwnersCartToShaba { get; set; }
        }

        public class RootCartToShaba
        {
            [JsonProperty("trackId")]
            public string TrackId { get; set; }

            [JsonProperty("result")]
            public ResultCartToShaba ResultCartToShaba { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }
        }
        ///////////////////////////////////////////////پایان تبدیل کارت به شبا //////////////////////////////////////////////////////////////
        ///                    استعلام شبا         ///////////////////////////////////////////////////
        public IActionResult EstelamShaba()
        {
            return View();
        }
        public IActionResult EstelamShabaResult (vm_Gardesh Gardesh)
        {
            var token=db.Tbl_TokenValues.SingleOrDefault().Token;


            var client = new RestClient("https://apibeta.finnotech.ir/facility/v2/clients/nikatak5250/depositToIban?deposit="+Gardesh.Deposit+"&bankCode="+Gardesh.To+"");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer"+" "+token);
            request.AddHeader("Cookie", "boomrangid=s%3AQb6IL1Thi0OgpfDht1c8_FUHstt3LHxu.ElfiIz7%2Bj2y6FVEjQyZxlVOHAT0C%2BKTaz5iN%2F122JnI");
            IRestResponse response = client.Execute(request);
            var CartShaba = JsonConvert.DeserializeObject<RootEstelamShaba>(response.Content);
            var s=CartShaba.ResultEstelamShaba;
            ViewBag.AccountStatus=s.AccountStatus;
            ViewBag.BankName=s.BankName;
            ViewBag.Deposit=s.Deposit;
            ViewBag.DepositOwners=s.DepositOwners;
            ViewBag.Iban=s.Iban;


            return View();
        }
         //                کلاس های دیسریالایز استعلام  شبا
                public class ResultEstelamShaba
                {
                    [JsonProperty("deposit")]
                    public string Deposit { get; set; }

                    [JsonProperty("accountStatus")]
                    public string AccountStatus { get; set; }

                    [JsonProperty("bankName")]
                    public string BankName { get; set; }

                    [JsonProperty("iban")]
                    public string Iban { get; set; }

                    [JsonProperty("depositOwners")]
                    public string DepositOwners { get; set; }
                }

                public class RootEstelamShaba
                {
                    [JsonProperty("trackId")]
                    public string TrackId { get; set; }

                    [JsonProperty("result")]
                    public ResultEstelamShaba ResultEstelamShaba { get; set; }

                    [JsonProperty("status")]
                    public string Status { get; set; }
                }
       
        ///////////////////////////////////////////////پایان تبدیل استعلام  شبا //////////////////////////////////////////////////////////////
    }
}
