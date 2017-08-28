﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;
using NetOffice.Attributes;

namespace NetOffice.VisioApi.Events
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByVersion("Visio", 11,12,14,15,16)]
    [InternalEntity(InternalEntityKind.ComEventInterface)]
    [ComImport, Guid("000D0B0D-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface ECell
	{
		[SupportByVersion("Visio", 11,12,14,15,16)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(10240)]
		void CellChanged([In, MarshalAs(UnmanagedType.IDispatch)] object cell);

		[SupportByVersion("Visio", 11,12,14,15,16)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(12288)]
		void FormulaChanged([In, MarshalAs(UnmanagedType.IDispatch)] object cell);
	}

    #endregion

    #region SinkHelper

    [InternalEntity(InternalEntityKind.SinkHelper)]
    [ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class ECell_SinkHelper : SinkHelper, ECell
	{
		#region Static
		
		public static readonly string Id = "000D0B0D-0000-0000-C000-000000000046";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private ICOMObject _eventClass;
        
		#endregion
		
		#region Construction

		public ECell_SinkHelper(ICOMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region Properties

        internal Core Factory
        {
            get
            {
                if (null != _eventClass)
                    return _eventClass.Factory;
                else
                    return Core.Default;
            }
        }

        #endregion

		#region ECell Members
		
		public void CellChanged([In, MarshalAs(UnmanagedType.IDispatch)] object cell)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("CellChanged");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(cell);
				return;
			}

			NetOffice.VisioApi.IVCell newCell = Factory.CreateObjectFromComProxy(_eventClass, cell) as NetOffice.VisioApi.IVCell;
			object[] paramsArray = new object[1];
			paramsArray[0] = newCell;
			_eventBinding.RaiseCustomEvent("CellChanged", ref paramsArray);
		}

		public void FormulaChanged([In, MarshalAs(UnmanagedType.IDispatch)] object cell)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("FormulaChanged");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(cell);
				return;
			}

			NetOffice.VisioApi.IVCell newCell = Factory.CreateObjectFromComProxy(_eventClass, cell) as NetOffice.VisioApi.IVCell;
			object[] paramsArray = new object[1];
			paramsArray[0] = newCell;
			_eventBinding.RaiseCustomEvent("FormulaChanged", ref paramsArray);
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}