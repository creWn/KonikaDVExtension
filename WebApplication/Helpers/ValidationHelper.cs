using System;
using System.Collections.Generic;

using WebApplication.Models;

namespace WebApplication.Helpers
{
    public static class ValidationHelper
    {
        public static List<string> Validate(CardCreateRequest request)
        {
            var result = new List<string>();
            if (request.CreationDate.HasValue && request.CreationDate.Value.TimeOfDay != TimeSpan.Zero)
                result.Add("CreationDate");

            if (request.MainAccount.HasValue && request.MainAccount.Value < 0)
                result.Add("MainAccount");

            if (request.CorrespondentAccount.HasValue && request.CorrespondentAccount.Value < 0)
                result.Add("CorrespondentAccount");

            if (request.OrderNumber.HasValue && (request.OrderNumber.Value < 0 || request.OrderNumber.Value.Length() != 8))
                result.Add("OrderNumber");

            return result;
        }
    }
}