using System;
using System.Collections.Generic;
using System.Text;

namespace AliceExchangeProtocol
{
    public enum AliceState
    {
         Open
       , WasGreeting
       , SelectedName, SelectedSize
       , InputedFIO, InputedAddress, InputedFloorNumber, InputedPhoneNumber, InputedCreditCard, InputedCardFIO
       , InputedCardEndDate, InputedCVC, Closed
    }

    public enum AliceTrigger
    {
          ShowGreeting
        , SelectName, SelectSize, InputFIO
        , InputedAddress, InputFloorNumber, InputPhoneNumber, InputCreditCard, InputCardFIO
        , InputCardEndDate, InputCVC, Close
    }
}
