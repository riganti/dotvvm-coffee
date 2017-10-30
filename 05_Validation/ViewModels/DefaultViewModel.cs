using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;
using System.ComponentModel.DataAnnotations;
using DotvvmCoffeeTemplate.Services;
using DotVVM.Framework.ViewModel.Validation;

namespace DotvvmCoffeeTemplate.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
        private readonly SubscribtionService subscriptionService = new SubscribtionService();

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Email address is not valid.")]
        public string Email { get; set; }

        public void Subscribe()
        {
            try
            {
                subscriptionService.Subscribe(Email);
                Email = "";
            }
            catch(EmailAlreadySubscribedException)
            {
                Context.ModelState.Errors.Add(new ViewModelValidationError()
                {
                    PropertyPath = nameof(Email),
                    ErrorMessage = "Email address is already registered!"
                });
                Context.FailOnInvalidModelState();
            }
        }
    }
}

