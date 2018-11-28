using AlisaExchangeProtocol.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlisaExchangeProtocol
{
    // Extensions.cs
    public static class Extensions
    {
        public static AliceResponse Reply(
          this AliceRequest req,
          string resText,
          bool endSession = false,
          List<ButtonModel> buttons = null) => new AliceResponse
          {
              text = resText,
              tts = resText,
              buttons = buttons,
              end_session = endSession,
              session = new Session()
              {
                  message_id = req.session.message_id,
                  session_id = req.session.session_id,
                  user_id = req.session.user_id
              }
          };
    }
}
