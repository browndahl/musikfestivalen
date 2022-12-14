using System;
using System.Net.NetworkInformation;
using festival.Client.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace festival.Client.Pages
{
    public partial class FrivilligePage
    {
        private Product ProductModel = new Product();
        private EditContext EditContext;

        protected override void OnInitialized()
        {
            EditContext = new EditContext(ProductModel);

        }

        private void HandleValidSubmit()
        {
            Console.WriteLine("HandleValidSubmit Called...");

            ProductModel = new Product();                       //Fjerner vores input(teskt) efter summit
            EditContext = new EditContext(ProductModel);

        }


        private void HandleInvalidSubmit()
        {
            Console.WriteLine("HandleInvalidSubmit Called...");
        }


    }


}

