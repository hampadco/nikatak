﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestSharp;
using Admin.Models;
using Newtonsoft;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authorization;

namespace Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MandeHesabController : Controller
    {



        ///select bank
        public IActionResult Index()
        {
            return View();
        }
        //create Access
        public IActionResult Access(string bankid)
        {

            var client = new RestSharp.RestClient("https://apibeta.finnotech.ir/dev/v2/oauth2/authorize?client_id=nikatak5250&response_type=code&redirect_uri=https://nikatak.ir/verify&scope=oak:balance:get&bank=" + bankid + "");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Basic bmlrYXRhazUyNTA6aEhYdjJDbGs3RHpuTTB5S1QwTjc=");
            request.AddHeader("Cookie", "boomrangid=s%3ATk2WBPGh3sUlrg5j3Xn-v6bVuWCcEuHw.PEXico%2FkAuoadncP%2B%2F%2FfsUelQWQlAFXiXR7S7Ycq5Yo; connect.sid=s%3Ad44HHRz3Hhn1b8mbpCg2kG5Ve_aVyWYh.T6vqOfZ6oBjRIM%2BWQ6%2FGLSoUWxfm0DUl9bvOW7LGvu8");
            IRestResponse response = client.Execute(request);



            var qwe="MandeHesab";
            HttpContext.Session.SetString("IdBank", bankid);
            HttpContext.Session.SetString("Ret", qwe);




            return Redirect(response.ResponseUri.ToString());



        }


        //create token
        public IActionResult Urlback()
        {
            var code=HttpContext.Session.GetString("CR");

            string bankid = HttpContext.Session.GetString("IdBank");

            var client = new RestClient("https://apibeta.finnotech.ir/dev/v2/oauth2/token");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Basic bmlrYXRhazUyNTA6aEhYdjJDbGs3RHpuTTB5S1QwTjc=");
            request.AddHeader("Cookie", "boomrangid=s%3Aa9wyuhzs0reZ3FhuFQdMNR-4iZWdspP7.bere%2BHtpg%2BqkQR0gA4g0%2FSIjox%2BLBihHeFjIkUPsHlo");
            var body =
            "{" +
            "\"grant_type\":\"authorization_code\","
            + "\"code\":\"" + code + "\","
             + "\"bank\":\"" + bankid + "\","
              + "\"redirect_uri\":\"https://nikatak.ir/verify\""
            + "}";


            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var value1 = JsonConvert.DeserializeObject<Root>(response.Content);
            HttpContext.Session.SetString("tokencode", value1.Result.Value);
            ViewBag.Hesabs = value1.Result.Deposits.ToList();

            return View();
        }
        public IActionResult result(vm_Gardesh Gardesh)
        {
            try
            {
                var token = HttpContext.Session.GetString("tokencode");
                var client = new RestClient("https://apibeta.finnotech.ir/oak/v2/clients/nikatak5250/deposits/"+Gardesh.Deposit+"/balance");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Authorization", "Bearer"+" "+token);
                request.AddHeader("Cookie", "boomrangid=s%3AUJCk7WO29No6Wvv0ZJ5A7LDv6whfjIWi.B4qNgSlMuXQlqzmeTg0lZ8oIWCunGG8YR8fa%2FKge%2Fw8");
                var body = @"";
                request.AddParameter("text/plain", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                var value2 = JsonConvert.DeserializeObject<Root1>(response.Content);

                ViewBag.resultAvailableBalance = value2.Result1.AvailableBalance;
                ViewBag.resultCurrentBalance = value2.Result1.CurrentBalance;
                ViewBag.resultEffectiveBalance = value2.Result1.EffectiveBalance;
                ViewBag.resultNumber = value2.Result1.Number;
            }
            catch (System.Exception ex)
            {
                ViewBag.resultAvailableBalance ="اطلاعاتی از سمت بانک دریافت نشد";
                ViewBag.resultCurrentBalance ="اطلاعاتی از سمت بانک دریافت نشد";
                ViewBag.resultEffectiveBalance ="اطلاعاتی از سمت بانک دریافت نشد";
                ViewBag.resultNumber ="اطلاعاتی از سمت بانک دریافت نشد";
            }
            

            return View();

        }

        //create token value
        public class Result
        {
            [JsonProperty("scopes")]
            public List<string> Scopes { get; set; }

            [JsonProperty("monthlyCallLimitation")]
            public int MonthlyCallLimitation { get; set; }

            [JsonProperty("maxAmountPerTransaction")]
            public int MaxAmountPerTransaction { get; set; }

            [JsonProperty("userId")]
            public string UserId { get; set; }

            [JsonProperty("creationDate")]
            public string CreationDate { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("bank")]
            public string Bank { get; set; }

            [JsonProperty("lifeTime")]
            public int LifeTime { get; set; }

            [JsonProperty("deposits")]
            public List<string> Deposits { get; set; }

            [JsonProperty("clientId")]
            public string ClientId { get; set; }

            [JsonProperty("value")]
            public string Value { get; set; }

            [JsonProperty("refreshToken")]
            public string RefreshToken { get; set; }
        }

        public class Root
        {
            [JsonProperty("result")]
            public Result Result { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }
        }





        

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Result1
    {
        [JsonProperty("availableBalance")]
        public int AvailableBalance { get; set; }

        [JsonProperty("effectiveBalance")]
        public int EffectiveBalance { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("currentBalance")]
        public int CurrentBalance { get; set; }
    }

    public class Root1
    {
        [JsonProperty("trackId")]
        public string TrackId { get; set; }

        [JsonProperty("result")]
        public Result1 Result1 { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }


    }
}
