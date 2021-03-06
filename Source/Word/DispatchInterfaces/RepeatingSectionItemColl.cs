﻿using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface RepeatingSectionItemColl 
	/// SupportByVersion Word, 15, 16
	/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj227247.aspx
	///</summary>
	[SupportByVersionAttribute("Word", 15, 16)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class RepeatingSectionItemColl : COMObject ,IEnumerable<NetOffice.WordApi.RepeatingSectionItem>
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(RepeatingSectionItemColl);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public RepeatingSectionItemColl(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public RepeatingSectionItemColl(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public RepeatingSectionItemColl(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public RepeatingSectionItemColl(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public RepeatingSectionItemColl(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public RepeatingSectionItemColl() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public RepeatingSectionItemColl(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 15,16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj228638.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 15, 16)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 15,16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj230383.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 15, 16)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 15,16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj229461.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Word", 15, 16)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 15,16
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj229731.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 15, 16)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 15,16
		/// 
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Word", 15, 16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.RepeatingSectionItem this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.RepeatingSectionItem newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.RepeatingSectionItem.LateBindingApiWrapperType) as NetOffice.WordApi.RepeatingSectionItem;
				return newObject;
			}
		}

		#endregion

       #region IEnumerable<NetOffice.WordApi.RepeatingSectionItem> Member
        
        /// <summary>
		/// SupportByVersionAttribute Word, 15, 16
		/// </summary>
		[SupportByVersionAttribute("Word", 15, 16)]
       public IEnumerator<NetOffice.WordApi.RepeatingSectionItem> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.WordApi.RepeatingSectionItem item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Word, 15, 16
		/// </summary>
		[SupportByVersionAttribute("Word", 15, 16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}