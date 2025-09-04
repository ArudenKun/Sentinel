#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class SukiToastHost_MarkupExtensions
{
//================= Properties ======================//
 // Manager

/*ValueSetterGenerator*/
public static T Manager<T>(this T control, SukiUI.Toasts.ISukiToastManager value) where T : SukiUI.Controls.SukiToastHost 
=> control._set(() => control.Manager = value!);

/*BindFromExpressionSetterGenerator*/
public static T Manager<T>(this T control, Func<SukiUI.Toasts.ISukiToastManager> func, Action<SukiUI.Toasts.ISukiToastManager>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiToastHost 
   => control._set(SukiUI.Controls.SukiToastHost.ManagerProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Manager<T>(this T control,SukiUI.Toasts.ISukiToastManager value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToastHost 
=> control._setEx(SukiUI.Controls.SukiToastHost.ManagerProperty, ps, () => control.Manager = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Manager<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiToastHost 
   => control._set(SukiUI.Controls.SukiToastHost.ManagerProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Manager<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiToastHost 
   => control._set(SukiUI.Controls.SukiToastHost.ManagerProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Manager<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, SukiUI.Toasts.ISukiToastManager> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToastHost 
=> control._setEx(SukiUI.Controls.SukiToastHost.ManagerProperty, ps, () => control.Manager = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MaxToasts

/*ValueSetterGenerator*/
public static T MaxToasts<T>(this T control, System.Byte value) where T : SukiUI.Controls.SukiToastHost 
=> control._set(() => control.MaxToasts = value!);

/*BindFromExpressionSetterGenerator*/
public static T MaxToasts<T>(this T control, Func<System.Byte> func, Action<System.Byte>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiToastHost 
   => control._set(SukiUI.Controls.SukiToastHost.MaxToastsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MaxToasts<T>(this T control,System.Byte value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToastHost 
=> control._setEx(SukiUI.Controls.SukiToastHost.MaxToastsProperty, ps, () => control.MaxToasts = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxToasts<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiToastHost 
   => control._set(SukiUI.Controls.SukiToastHost.MaxToastsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxToasts<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiToastHost 
   => control._set(SukiUI.Controls.SukiToastHost.MaxToastsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MaxToasts<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Byte> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToastHost 
=> control._setEx(SukiUI.Controls.SukiToastHost.MaxToastsProperty, ps, () => control.MaxToasts = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Position

/*ValueSetterGenerator*/
public static T Position<T>(this T control, SukiUI.Enums.ToastLocation value) where T : SukiUI.Controls.SukiToastHost 
=> control._set(() => control.Position = value!);

/*BindFromExpressionSetterGenerator*/
public static T Position<T>(this T control, Func<SukiUI.Enums.ToastLocation> func, Action<SukiUI.Enums.ToastLocation>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiToastHost 
   => control._set(SukiUI.Controls.SukiToastHost.PositionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Position<T>(this T control,SukiUI.Enums.ToastLocation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToastHost 
=> control._setEx(SukiUI.Controls.SukiToastHost.PositionProperty, ps, () => control.Position = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Position<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiToastHost 
   => control._set(SukiUI.Controls.SukiToastHost.PositionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Position<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiToastHost 
   => control._set(SukiUI.Controls.SukiToastHost.PositionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Position<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, SukiUI.Enums.ToastLocation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiToastHost 
=> control._setEx(SukiUI.Controls.SukiToastHost.PositionProperty, ps, () => control.Position = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Manager

/*ValueStyleSetterGenerator*/
public static Style<T> Manager<T>(this Style<T> style, SukiUI.Toasts.ISukiToastManager value) where T : SukiUI.Controls.SukiToastHost 
=> style._addSetter(SukiUI.Controls.SukiToastHost.ManagerProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Manager<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiToastHost 
=> style._addSetter(SukiUI.Controls.SukiToastHost.ManagerProperty, binding);


 // MaxToasts

/*ValueStyleSetterGenerator*/
public static Style<T> MaxToasts<T>(this Style<T> style, System.Byte value) where T : SukiUI.Controls.SukiToastHost 
=> style._addSetter(SukiUI.Controls.SukiToastHost.MaxToastsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxToasts<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiToastHost 
=> style._addSetter(SukiUI.Controls.SukiToastHost.MaxToastsProperty, binding);


 // Position

/*ValueStyleSetterGenerator*/
public static Style<T> Position<T>(this Style<T> style, SukiUI.Enums.ToastLocation value) where T : SukiUI.Controls.SukiToastHost 
=> style._addSetter(SukiUI.Controls.SukiToastHost.PositionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Position<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiToastHost 
=> style._addSetter(SukiUI.Controls.SukiToastHost.PositionProperty, binding);



}
