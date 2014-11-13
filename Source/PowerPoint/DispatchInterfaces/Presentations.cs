using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface Presentations 
	/// SupportByVersion PowerPoint, 9,10,11,12,14,15
	/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff743968.aspx
	///</summary>
	[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Presentations : Collection
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
                    _type = typeof(Presentations);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public Presentations(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Presentations(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Presentations(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Presentations(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Presentations(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Presentations() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Presentations(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744974.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Application.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744972.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15)]
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

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.PowerPointApi.Presentation this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745733.aspx
		/// </summary>
		/// <param name="withWindow">optional NetOffice.OfficeApi.Enums.MsoTriState WithWindow = -1</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15)]
		public NetOffice.PowerPointApi.Presentation Add(NetOffice.OfficeApi.Enums.MsoTriState withWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(withWindow);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745733.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15)]
		public NetOffice.PowerPointApi.Presentation Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746171.aspx
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="readOnly">optional NetOffice.OfficeApi.Enums.MsoTriState ReadOnly = 0</param>
		/// <param name="untitled">optional NetOffice.OfficeApi.Enums.MsoTriState Untitled = 0</param>
		/// <param name="withWindow">optional NetOffice.OfficeApi.Enums.MsoTriState WithWindow = -1</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15)]
		public NetOffice.PowerPointApi.Presentation Open(string fileName, NetOffice.OfficeApi.Enums.MsoTriState readOnly, NetOffice.OfficeApi.Enums.MsoTriState untitled, NetOffice.OfficeApi.Enums.MsoTriState withWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, readOnly, untitled, withWindow);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746171.aspx
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15)]
		public NetOffice.PowerPointApi.Presentation Open(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746171.aspx
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="readOnly">optional NetOffice.OfficeApi.Enums.MsoTriState ReadOnly = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15)]
		public NetOffice.PowerPointApi.Presentation Open(string fileName, NetOffice.OfficeApi.Enums.MsoTriState readOnly)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, readOnly);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746171.aspx
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="readOnly">optional NetOffice.OfficeApi.Enums.MsoTriState ReadOnly = 0</param>
		/// <param name="untitled">optional NetOffice.OfficeApi.Enums.MsoTriState Untitled = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15)]
		public NetOffice.PowerPointApi.Presentation Open(string fileName, NetOffice.OfficeApi.Enums.MsoTriState readOnly, NetOffice.OfficeApi.Enums.MsoTriState untitled)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, readOnly, untitled);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="readOnly">optional NetOffice.OfficeApi.Enums.MsoTriState ReadOnly = 0</param>
		/// <param name="untitled">optional NetOffice.OfficeApi.Enums.MsoTriState Untitled = 0</param>
		/// <param name="withWindow">optional NetOffice.OfficeApi.Enums.MsoTriState WithWindow = -1</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15)]
		public NetOffice.PowerPointApi.Presentation OpenOld(string fileName, NetOffice.OfficeApi.Enums.MsoTriState readOnly, NetOffice.OfficeApi.Enums.MsoTriState untitled, NetOffice.OfficeApi.Enums.MsoTriState withWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, readOnly, untitled, withWindow);
			object returnItem = Invoker.MethodReturn(this, "OpenOld", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15)]
		public NetOffice.PowerPointApi.Presentation OpenOld(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "OpenOld", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="readOnly">optional NetOffice.OfficeApi.Enums.MsoTriState ReadOnly = 0</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15)]
		public NetOffice.PowerPointApi.Presentation OpenOld(string fileName, NetOffice.OfficeApi.Enums.MsoTriState readOnly)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, readOnly);
			object returnItem = Invoker.MethodReturn(this, "OpenOld", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="readOnly">optional NetOffice.OfficeApi.Enums.MsoTriState ReadOnly = 0</param>
		/// <param name="untitled">optional NetOffice.OfficeApi.Enums.MsoTriState Untitled = 0</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15)]
		public NetOffice.PowerPointApi.Presentation OpenOld(string fileName, NetOffice.OfficeApi.Enums.MsoTriState readOnly, NetOffice.OfficeApi.Enums.MsoTriState untitled)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, readOnly, untitled);
			object returnItem = Invoker.MethodReturn(this, "OpenOld", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746209.aspx
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15)]
		public void CheckOut(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			Invoker.Method(this, "CheckOut", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745034.aspx
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14,15)]
		public bool CanCheckOut(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "CanCheckOut", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744741.aspx
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="readOnly">optional NetOffice.OfficeApi.Enums.MsoTriState ReadOnly = 0</param>
		/// <param name="untitled">optional NetOffice.OfficeApi.Enums.MsoTriState Untitled = 0</param>
		/// <param name="withWindow">optional NetOffice.OfficeApi.Enums.MsoTriState WithWindow = -1</param>
		/// <param name="openAndRepair">optional NetOffice.OfficeApi.Enums.MsoTriState OpenAndRepair = 0</param>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.PowerPointApi.Presentation Open2007(string fileName, NetOffice.OfficeApi.Enums.MsoTriState readOnly, NetOffice.OfficeApi.Enums.MsoTriState untitled, NetOffice.OfficeApi.Enums.MsoTriState withWindow, NetOffice.OfficeApi.Enums.MsoTriState openAndRepair)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, readOnly, untitled, withWindow, openAndRepair);
			object returnItem = Invoker.MethodReturn(this, "Open2007", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744741.aspx
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.PowerPointApi.Presentation Open2007(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "Open2007", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744741.aspx
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="readOnly">optional NetOffice.OfficeApi.Enums.MsoTriState ReadOnly = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.PowerPointApi.Presentation Open2007(string fileName, NetOffice.OfficeApi.Enums.MsoTriState readOnly)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, readOnly);
			object returnItem = Invoker.MethodReturn(this, "Open2007", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744741.aspx
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="readOnly">optional NetOffice.OfficeApi.Enums.MsoTriState ReadOnly = 0</param>
		/// <param name="untitled">optional NetOffice.OfficeApi.Enums.MsoTriState Untitled = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.PowerPointApi.Presentation Open2007(string fileName, NetOffice.OfficeApi.Enums.MsoTriState readOnly, NetOffice.OfficeApi.Enums.MsoTriState untitled)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, readOnly, untitled);
			object returnItem = Invoker.MethodReturn(this, "Open2007", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744741.aspx
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="readOnly">optional NetOffice.OfficeApi.Enums.MsoTriState ReadOnly = 0</param>
		/// <param name="untitled">optional NetOffice.OfficeApi.Enums.MsoTriState Untitled = 0</param>
		/// <param name="withWindow">optional NetOffice.OfficeApi.Enums.MsoTriState WithWindow = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.PowerPointApi.Presentation Open2007(string fileName, NetOffice.OfficeApi.Enums.MsoTriState readOnly, NetOffice.OfficeApi.Enums.MsoTriState untitled, NetOffice.OfficeApi.Enums.MsoTriState withWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, readOnly, untitled, withWindow);
			object returnItem = Invoker.MethodReturn(this, "Open2007", paramsArray);
			NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}