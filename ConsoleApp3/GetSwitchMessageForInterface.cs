using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NetConf.NetConfReadShell
{
    public class GetSwitchMessageForInterface
    {
        /// <summary>
        /// 获取交换机信息发送命令
        /// </summary>

        /// <param name="PassWord">密钥</param>
        /// <returns></returns>
        public static string GetSwitchMessage( string PassWord)
        {
            

            StringBuilder str = new StringBuilder();

            str.Append("<env:Envelope xmlns:env='http://www.w3.org/2003/05/soap-envelope'>");
            str.Append("<env:Header>");
            str.Append("<auth:Authentication env:mustUnderstand='1' xmlns:auth='http://www.h3c.com/netconf/base:1.0'>");
            str.Append("<auth:AuthInfo>" + PassWord + "</auth:AuthInfo>");
            str.Append("</auth:Authentication>");
            str.Append("</env:Header>");
            str.Append("<env:Body>");
            str.Append("<rpc message-id ='100' xmlns='urn:ietf:params:xml:ns:netconf:base:1.0'>");
            str.Append("<get-bulk>");
            str.Append("<filter type='subtree'>");
            str.Append("<top xmlns='http://www.h3c.com/netconf/data:1.0'>");
            str.Append("<Ifmgr>");
            str.Append("</Ifmgr>");
            str.Append("</top>");
            str.Append("</filter>");
            str.Append("</get-bulk>");
            str.Append("</rpc>");
            str.Append("</env:Body>");
            str.Append("</env:Envelope>");

            return str.ToString();
        }
    }
}
