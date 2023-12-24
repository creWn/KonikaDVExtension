using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Newtonsoft.Json;

using WebApplication.Helpers;
using WebApplication.Models;
using WebApplication.ObjectModel;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    public class CardController : ApiController
    {
        [HttpPost]
        public object Create(CardCreateRequest request)
        {
            var authHeader = Request.Headers.Authorization;
            if (authHeader.Scheme != "DV")
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));

            var authModel = AuthorizationHelper.GetCredentials(authHeader);
            if (authModel == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));

            var errors = ValidationHelper.Validate(request);
            if (errors.Count > 0)
            {
                var reasonPhrase = string.Join(";", errors);
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest) { ReasonPhrase = reasonPhrase });
            }

            var sessionService = new SessionService();
            var userSession = sessionService.CreateSession(authModel);
            var objectContext = sessionService.GetObjectContext(userSession);

            var fileId = Guid.Empty;
            if (request.Attachment != null)
            {
                var file = userSession.FileManager.CreateFile(request.Attachment.Name);
                using (var attachStream = new MemoryStream(request.Attachment.Data))
                using (var fileStream = file.OpenWriteStream())
                {
                    attachStream.Position = 0;
                    attachStream.CopyTo(fileStream);
                }

                fileId = file.Id;
            }

            var card = new MyTypeCard();
            card.MainSection.DocKind = request.DocKind;
            card.MainSection.DocNumber = request.DocNumber;
            card.MainSection.CreationDate = request.CreationDate;
            card.MainSection.MainAccount = request.MainAccount;
            card.MainSection.CorrespondentAccount = request.CorrespondentAccount;
            card.MainSection.PartnerCode = request.PartnerCode;
            card.MainSection.OrderNumber = request.OrderNumber;
            card.MainSection.ExtraInfo = request.ExtraInfo;
            card.MainSection.Warehouse = request.Warehouse;
            card.MainSection.ShortContent = request.ShortContent;
            card.MainSection.ProvidingNumber = request.ProvidingNumber;
            card.MainSection.LoadDate = request.LoadDate;

            if (fileId != Guid.Empty)
                card.MainSection.Attachment = fileId;

            objectContext.AddObject(card);
            objectContext.SaveObject(card);
            var id = objectContext.GetObjectRef(card);

            return JsonConvert.SerializeObject(id.Id);
        }
    }
}
