using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Edu.Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// GET方法
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ApiExplorerSettings(GroupName = "v2")]
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        /// <summary>
        /// POST方法
        /// </summary>
        /// <param name="value"></param>
        [ApiExplorerSettings(GroupName = "v2")]
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        /// <summary>
        /// 修改
        /// </summary>
        /// <remarks>
        /// 例子:
        /// Get api/Values/1
        /// </remarks>
        /// <param name="id">主键</param>
        /// <param name="value">测试字符串</param>
        [ApiExplorerSettings(GroupName = "v1")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">主键</param>
        [ApiExplorerSettings(GroupName = "v1")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
