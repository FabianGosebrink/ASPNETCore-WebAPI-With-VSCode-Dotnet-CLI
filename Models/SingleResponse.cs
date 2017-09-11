using System.Collections.Generic;

namespace DotnetcliWebApi.Models
{
    public class SingleResponse<T>
    {
        public T Value { get; set; }
        public List<Link> Links { get; set; }
    }
}