using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using FF.Analysis.Core.UI.Attributes;
using FF.Analysis.Core.Extensions;
using System.Web.UI;

namespace FF.Analysis.Core.UI
{
    /// <summary>
    /// This is a Base UserCotrol
    /// </summary>
    public class BaseUserControl:UserControl
    {
        protected override void OnInit(EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request["qq"]))
            {
                this.State = Request["qq"].ToString();
            }
            
                var typesWithMyAttribute = from a in AppDomain.CurrentDomain.GetAssemblies()
                                           from t in a.GetTypes()
                                           let attributes = t.GetCustomAttributes(typeof(StatusNameAttribute), true)
                                           where attributes != null && attributes.Length > 0
                                           select new { Type = t, Attributes = attributes.Cast<StatusNameAttribute>() };

                var q = typesWithMyAttribute.ToList().Where(x => x.Attributes.Where(c => c.Name == StateName).Count() > 0).FirstOrDefault();

                Type myClassType = null;

                if (q != null)
                {
                    myClassType = q.Type;

                    RegisterState(State, myClassType);
                }

                base.OnInit(e);
        }

        public string StateName
        {
            set { ViewState["StateName"] = value; }
            get { return ViewState["StateName"].ToString(); }
        }

        /// <summary>
        /// Now State
        /// </summary>
        public string State
        {
            set { ViewState["State"] = value; }
            get { return ViewState["State"].ToString(); }
        }

        private void RegisterState(object t, Type enumType)
        {
            if (!enumType.IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type");
            }

            Type type = GetAttributeValue<LayoutTypeAttribute, Type>(t.ToString(), enumType, x => x.LayoutType);

            object obj = Activator.CreateInstance(type);

            

            
        }

        private Expected GetAttributeValue<T, Expected>(string enumString, Type enumType, Func<T, Expected> expression)
            where T : Attribute
        {
            var enumeration = Enum.Parse(enumType, enumString, true);

            T attribute = enumeration.GetType().GetMember(enumeration.ToString())[0].GetCustomAttributes(typeof(T), false).Cast<T>().SingleOrDefault();
            if (attribute == null)
            {
                return default(Expected);
            }

            return expression(attribute);
        } 
    }
}
