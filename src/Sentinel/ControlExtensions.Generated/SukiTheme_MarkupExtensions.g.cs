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
public static partial class SukiTheme_MarkupExtensions
{
//================= Properties ======================//
 // ThemeColor

/*ValueSetterGenerator*/
public static T ThemeColor<T>(this T control, SukiUI.Enums.SukiColor value) where T : SukiUI.SukiTheme 
=> control._set(() => control.ThemeColor = value!);

/*BindFromExpressionSetterGenerator*/
public static T ThemeColor<T>(this T control, Func<SukiUI.Enums.SukiColor> func, Action<SukiUI.Enums.SukiColor>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.SukiTheme 
   => control._set(SukiUI.SukiTheme.ThemeColorProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ThemeColor<T>(this T control,SukiUI.Enums.SukiColor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.SukiTheme 
=> control._setEx(SukiUI.SukiTheme.ThemeColorProperty, ps, () => control.ThemeColor = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ThemeColor<T>(this T control, IBinding binding) where T : SukiUI.SukiTheme 
   => control._set(SukiUI.SukiTheme.ThemeColorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ThemeColor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.SukiTheme 
   => control._set(SukiUI.SukiTheme.ThemeColorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ThemeColor<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, SukiUI.Enums.SukiColor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.SukiTheme 
=> control._setEx(SukiUI.SukiTheme.ThemeColorProperty, ps, () => control.ThemeColor = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsRightToLeft

/*ValueSetterGenerator*/
public static T IsRightToLeft<T>(this T control, System.Boolean value) where T : SukiUI.SukiTheme 
=> control._set(() => control.IsRightToLeft = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsRightToLeft<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.SukiTheme 
   => control._set(SukiUI.SukiTheme.IsRightToLeftProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsRightToLeft<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.SukiTheme 
=> control._setEx(SukiUI.SukiTheme.IsRightToLeftProperty, ps, () => control.IsRightToLeft = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsRightToLeft<T>(this T control, IBinding binding) where T : SukiUI.SukiTheme 
   => control._set(SukiUI.SukiTheme.IsRightToLeftProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsRightToLeft<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.SukiTheme 
   => control._set(SukiUI.SukiTheme.IsRightToLeftProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsRightToLeft<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.SukiTheme 
=> control._setEx(SukiUI.SukiTheme.IsRightToLeftProperty, ps, () => control.IsRightToLeft = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}
