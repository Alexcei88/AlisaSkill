using System;
using System.Collections.Generic;
using System.Text;

namespace AliceExchangeProtocol
{
    public enum AliceState { Open, SelectedName, SelectedSize, InputedFIO, InputedAddress, InputedFloorNumber, InputedPhoneNumber, InputedCreditCard, InputedCardFIO
            , InputedCardEndDate, InputedCVC, Closed }

    public enum AliceTrigger { SelectName, SelectSize, InputFIO, InputedAddress, InputFloorNumber, InputPhoneNumber, InputCreditCard, InputCardFIO
            , InputCardEndDate, InputCVC, Close }
}
