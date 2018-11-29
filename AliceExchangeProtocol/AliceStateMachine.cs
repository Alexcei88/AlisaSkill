﻿using PizzaOrderService;
using PizzaOrderService.Domain;
using Stateless;
using System;
using System.Collections.Generic;
using System.Text;

namespace AliceExchangeProtocol
{
    public class AliceStateMachine
    {
        private OrderRequest _request;

        private IPizzaOrderService _pizzaService;

        private Lazy<Pizza[]> _pizzaList;

        private StateMachine<AliceState, AliceTrigger> _stateMachine;

        public AliceStateMachine(IPizzaOrderService pizzaService)
        {
            _pizzaService = pizzaService;
            _pizzaList = new Lazy<Pizza[]>(() => _pizzaService.GetAvailablePizza());

            ConfigureStateMachine();
        }

        private void ConfigureStateMachine()
        {
            _stateMachine = new StateMachine<AliceState, AliceTrigger>(AliceState.Open);

            var assignTrigger = _stateMachine.SetTriggerParameters<string>(AliceTrigger.SelectName);

            _stateMachine.Configure(AliceState.Open)
                .Permit(AliceTrigger.SelectName, AliceState.SelectedName);

            _stateMachine.Configure(AliceState.SelectedName)
                .Permit(AliceTrigger.SelectSize, AliceState.SelectedSize);

            _stateMachine.Configure(AliceState.SelectedSize)
                .Permit(AliceTrigger.InputFIO, AliceState.InputedFIO);

            _stateMachine.Configure(AliceState.InputedFIO)
                .Permit(AliceTrigger.InputedAddress, AliceState.InputedAddress);

            _stateMachine.Configure(AliceState.InputedAddress)
                .Permit(AliceTrigger.InputFloorNumber, AliceState.InputedFloorNumber);

            _stateMachine.Configure(AliceState.InputedFloorNumber)
                .Permit(AliceTrigger.InputPhoneNumber, AliceState.InputedPhoneNumber);

            _stateMachine.Configure(AliceState.InputedPhoneNumber)
                .Permit(AliceTrigger.InputCreditCard, AliceState.InputedCreditCard);

            _stateMachine.Configure(AliceState.InputedPhoneNumber)
                .Permit(AliceTrigger.InputCreditCard, AliceState.InputedCreditCard);

            _stateMachine.Configure(AliceState.InputedCreditCard)
                            .Permit(AliceTrigger.InputCardFIO, AliceState.InputedCardFIO);

            _stateMachine.Configure(AliceState.InputedCardEndDate)
                            .Permit(AliceTrigger.InputCVC, AliceState.InputedCVC);

            _stateMachine.Configure(AliceState.InputedCVC)
                            .Permit(AliceTrigger.Close, AliceState.Closed);

        }
    }
}
