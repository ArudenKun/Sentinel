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
public static partial class SettingsLayoutItem_MarkupExtensions
{
//================= Properties ======================//
 // Header

/*ValueSetterGenerator*/
public static T Header<T>(this T control, System.String value) where T : SukiUI.Controls.SettingsLayoutItem 
=> control._set(() => control.Header = value!);

/*BindFromExpressionSetterGenerator*/
public static T Header<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SettingsLayoutItem 
   => control._set(SukiUI.Controls.SettingsLayoutItem.HeaderProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Header<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SettingsLayoutItem 
=> control._setEx(SukiUI.Controls.SettingsLayoutItem.HeaderProperty, ps, () => control.Header = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Header<T>(this T control, IBinding binding) where T : SukiUI.Controls.SettingsLayoutItem 
   => control._set(SukiUI.Controls.SettingsLayoutItem.HeaderProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Header<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SettingsLayoutItem 
   => control._set(SukiUI.Controls.SettingsLayoutItem.HeaderProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Header<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SettingsLayoutItem 
=> control._setEx(SukiUI.Controls.SettingsLayoutItem.HeaderProperty, ps, () => control.Header = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Content

/*ValueSetterGenerator*/
public static T Content<T>(this T control, Avalonia.Controls.Control value) where T : SukiUI.Controls.SettingsLayoutItem 
=> control._set(() => control.Content = value!);

/*BindFromExpressionSetterGenerator*/
public static T Content<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SettingsLayoutItem 
   => control._set(SukiUI.Controls.SettingsLayoutItem.ContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Content<T>(this T control,Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SettingsLayoutItem 
=> control._setEx(SukiUI.Controls.SettingsLayoutItem.ContentProperty, ps, () => control.Content = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Content<T>(this T control, IBinding binding) where T : SukiUI.Controls.SettingsLayoutItem 
   => control._set(SukiUI.Controls.SettingsLayoutItem.ContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Content<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SettingsLayoutItem 
   => control._set(SukiUI.Controls.SettingsLayoutItem.ContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Content<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SettingsLayoutItem 
=> control._setEx(SukiUI.Controls.SettingsLayoutItem.ContentProperty, ps, () => control.Content = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}
