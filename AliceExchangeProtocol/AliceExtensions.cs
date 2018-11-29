using AlisaExchangeProtocol.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlisaExchangeProtocol
{
    public static class AliceExtensions
    {
        public static AliceResponse Reply(
          this AliceRequest req,
          string resText,
          bool endSession = false,
          List<ButtonModel> buttons = null) => new AliceResponse
          {
              response = new ResponseModel()
              {
                  text = resText,
                  tts = resText,
                  buttons = buttons,
                  end_session = endSession
              },
              session = new Session()
              {
                  message_id = req.session.message_id,
                  session_id = req.session.session_id,
                  user_id = req.session.user_id
              }
          };
    }
}
