using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.DTOs
{
    public class ResponseDTO<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        public List<string>? Errors { get; set; }

        public static ResponseDTO<T> Success(int statusCode, T data)
        {
            return new ResponseDTO<T> { Data = data, StatusCode = statusCode };
        }

        public static ResponseDTO<T> Success(int statusCode)
        {
            return new ResponseDTO<T> { StatusCode = statusCode };
        }

        public static ResponseDTO<T> Fail(int statusCode, List<string> errors)
        {
            return new ResponseDTO<T> { StatusCode = statusCode, Errors = errors };
        }

        public static ResponseDTO<T> Fail(int statusCode, string error)
        {
            return new ResponseDTO<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }

        public static ResponseDTO<SellerDTO> Success(int v, object sellerDto)
        {
            throw new NotImplementedException();
        }
    }
    }

