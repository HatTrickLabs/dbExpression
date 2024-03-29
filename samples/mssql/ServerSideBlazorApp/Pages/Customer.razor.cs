﻿using Microsoft.AspNetCore.Components;
using ServerSideBlazorApp.Data;
using ServerSideBlazorApp.Models;
using System.Threading.Tasks;

namespace ServerSideBlazorApp.Pages
{
    public partial class Customer
    {
        #region internals
        private bool ShowProgressBar { get; set; } = false;
        private string? ReturnUrl { get; set; }
        private CustomerDetailModel? Model { get; set; }
        private string SelectedTab { get; set; } = Tabs.Details.Id;
        private bool ShowOrdersView => SelectedTab == Tabs.Orders.Id;
        #endregion

        #region interface
        [Parameter] public string? Id { get; set; }
        [Parameter] public int PageIndex { get; set; } = 0;
        [Parameter] public int PageSize { get; set; } = 5;
        [Parameter] public string? SearchPhrase { get; set; }
        #endregion

        #region methods
        private AddressModel? ResolveAddress(AddressType addressType)
            => addressType switch
            {
                AddressType.Mailing => Model?.MailingAddress,
                AddressType.Shipping => Model?.ShippingAddress,
                AddressType.Billing => Model?.BillingAddress,
                _ => null
            };

        private async Task<AddressModel> SaveAsync(AddressModel address)
            => await CustomerService.SaveAddressAsync(Model!.Id, address);

        protected override async Task OnInitializedAsync()
        {
            if (Id is not null && await CustomerService.GetCustomerDetailAsync(int.Parse(Id)) is CustomerDetailModel customer)
            {
                Model = customer;
            }
        }

        private async Task<Page<OrderSummaryModel>> GetOrderSummaryPageAsync(PagingParameters pagingParameters)
        {
            ShowProgressBar = true;

            try
            {
                return await OrderService.GetCustomerOrdersPageAsync(Model!.Id, pagingParameters);
            }
            finally
            {
                ShowProgressBar = false;
            }
        }

        private async Task<OrderDetailModel?> GetOrderDetailAsync(int orderId)
        {
            ShowProgressBar = true;

            try
            {
                return await OrderService.GetOrderAsync(orderId);
            }
            finally
            {
                ShowProgressBar = false;
            }
        }

        public async override Task SetParametersAsync(ParameterView parameters)
        {
            ReturnUrl = NavigationManager.GetReturnUrl();
            await base.SetParametersAsync(parameters);
        }

        private void OnSelectedTabChanged(string id)
        {
            SelectedTab = id;
        }
        #endregion

        private static class Tabs
        {
            public static (string Id, string Label) Details => ("Details", "Details");
            public static (string Id, string Label) Orders => ("Orders", "Order History");
        }
    }
}
