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
public static partial class SettingsLayout_MarkupExtensions
{
//================= Properties ======================//
 // Items

/*ValueSetterGenerator*/
public static T Items<T>(this T control, System.Collections.Generic.IEnumerable<SukiUI.Controls.SettingsLayoutItem> value) where T : SukiUI.Controls.SettingsLayout 
=> control._set(() => control.Items = value!);

/*BindFromExpressionSetterGenerator*/
public static T Items<T>(this T control, Func<System.Collections.Generic.IEnumerable<SukiUI.Controls.SettingsLayoutItem>> func, Action<System.Collections.Generic.IEnumerable<SukiUI.Controls.SettingsLayoutItem>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SettingsLayout 
   => control._set(SukiUI.Controls.SettingsLayout.ItemsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Items<T>(this T control,System.Collections.Generic.IEnumerable<SukiUI.Controls.SettingsLayoutItem> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SettingsLayout 
=> control._setEx(SukiUI.Controls.SettingsLayout.ItemsProperty, ps, () => control.Items = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Items<T>(this T control, IBinding binding) where T : SukiUI.Controls.SettingsLayout 
   => control._set(SukiUI.Controls.SettingsLayout.ItemsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Items<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SettingsLayout 
   => control._set(SukiUI.Controls.SettingsLayout.ItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Items<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IEnumerable<SukiUI.Controls.SettingsLayoutItem>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SettingsLayout 
=> control._setEx(SukiUI.Controls.SettingsLayout.ItemsProperty, ps, () => control.Items = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // StackSummaryWidth

/*ValueSetterGenerator*/
public static T StackSummaryWidth<T>(this T control, System.Double value) where T : SukiUI.Controls.SettingsLayout 
=> control._set(() => control.StackSummaryWidth = value!);

/*BindFromExpressionSetterGenerator*/
public static T StackSummaryWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SettingsLayout 
   => control._set(SukiUI.Controls.SettingsLayout.StackSummaryWidthProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T StackSummaryWidth<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SettingsLayout 
=> control._setEx(SukiUI.Controls.SettingsLayout.StackSummaryWidthProperty, ps, () => control.StackSummaryWidth = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StackSummaryWidth<T>(this T control, IBinding binding) where T : SukiUI.Controls.SettingsLayout 
   => control._set(SukiUI.Controls.SettingsLayout.StackSummaryWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StackSummaryWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SettingsLayout 
   => control._set(SukiUI.Controls.SettingsLayout.StackSummaryWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T StackSummaryWidth<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SettingsLayout 
=> control._setEx(SukiUI.Controls.SettingsLayout.StackSummaryWidthProperty, ps, () => control.StackSummaryWidth = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // StackSummaryWidth

/*ValueStyleSetterGenerator*/
public static Style<T> StackSummaryWidth<T>(this Style<T> style, System.Double value) where T : SukiUI.Controls.SettingsLayout 
=> style._addSetter(SukiUI.Controls.SettingsLayout.StackSummaryWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StackSummaryWidth<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SettingsLayout 
=> style._addSetter(SukiUI.Controls.SettingsLayout.StackSummaryWidthProperty, binding);



}
