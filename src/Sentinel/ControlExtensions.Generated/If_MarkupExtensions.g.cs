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
public static partial class If_MarkupExtensions
{
//================= Properties ======================//
 // Condition

/*ValueSetterGenerator*/
public static T Condition<T>(this T control, System.String value) where T : SukiUI.Helpers.ConditionalXAML.If 
=> control._set(() => control.Condition = value!);

/*BindFromExpressionSetterGenerator*/
public static T Condition<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Helpers.ConditionalXAML.If 
   => control._set(SukiUI.Helpers.ConditionalXAML.If.ConditionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Condition<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Helpers.ConditionalXAML.If 
=> control._setEx(SukiUI.Helpers.ConditionalXAML.If.ConditionProperty, ps, () => control.Condition = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Condition<T>(this T control, IBinding binding) where T : SukiUI.Helpers.ConditionalXAML.If 
   => control._set(SukiUI.Helpers.ConditionalXAML.If.ConditionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Condition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Helpers.ConditionalXAML.If 
   => control._set(SukiUI.Helpers.ConditionalXAML.If.ConditionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Condition<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Helpers.ConditionalXAML.If 
=> control._setEx(SukiUI.Helpers.ConditionalXAML.If.ConditionProperty, ps, () => control.Condition = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Condition

/*ValueStyleSetterGenerator*/
public static Style<T> Condition<T>(this Style<T> style, System.String value) where T : SukiUI.Helpers.ConditionalXAML.If 
=> style._addSetter(SukiUI.Helpers.ConditionalXAML.If.ConditionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Condition<T>(this Style<T> style, IBinding binding) where T : SukiUI.Helpers.ConditionalXAML.If 
=> style._addSetter(SukiUI.Helpers.ConditionalXAML.If.ConditionProperty, binding);



}
