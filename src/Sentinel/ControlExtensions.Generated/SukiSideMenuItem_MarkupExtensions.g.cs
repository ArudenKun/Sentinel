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
public static partial class SukiSideMenuItem_MarkupExtensions
{
//================= Properties ======================//
 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, System.Object value) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._set(() => control.Icon = value!);

/*BindFromExpressionSetterGenerator*/
public static T Icon<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.IconProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Icon<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._setEx(SukiUI.Controls.SukiSideMenuItem.IconProperty, ps, () => control.Icon = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Icon<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.IconProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Icon<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._setEx(SukiUI.Controls.SukiSideMenuItem.IconProperty, ps, () => control.Icon = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Header

/*ValueSetterGenerator*/
public static T Header<T>(this T control, System.String value) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._set(() => control.Header = value!);

/*BindFromExpressionSetterGenerator*/
public static T Header<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.HeaderProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Header<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._setEx(SukiUI.Controls.SukiSideMenuItem.HeaderProperty, ps, () => control.Header = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Header<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.HeaderProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Header<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.HeaderProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Header<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._setEx(SukiUI.Controls.SukiSideMenuItem.HeaderProperty, ps, () => control.Header = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PageContent

/*ValueSetterGenerator*/
public static T PageContent<T>(this T control, System.Object value) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._set(() => control.PageContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T PageContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.PageContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PageContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._setEx(SukiUI.Controls.SukiSideMenuItem.PageContentProperty, ps, () => control.PageContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PageContent<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.PageContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PageContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.PageContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PageContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._setEx(SukiUI.Controls.SukiSideMenuItem.PageContentProperty, ps, () => control.PageContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SideDisplayTemplate

/*ValueSetterGenerator*/
public static T SideDisplayTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._set(() => control.SideDisplayTemplate = value!);

/*BindFromExpressionSetterGenerator*/
public static T SideDisplayTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.SideDisplayTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SideDisplayTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._setEx(SukiUI.Controls.SukiSideMenuItem.SideDisplayTemplateProperty, ps, () => control.SideDisplayTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SideDisplayTemplate<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.SideDisplayTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SideDisplayTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.SideDisplayTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SideDisplayTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._setEx(SukiUI.Controls.SukiSideMenuItem.SideDisplayTemplateProperty, ps, () => control.SideDisplayTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsContentMovable

/*ValueSetterGenerator*/
public static T IsContentMovable<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._set(() => control.IsContentMovable = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsContentMovable<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.IsContentMovableProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsContentMovable<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._setEx(SukiUI.Controls.SukiSideMenuItem.IsContentMovableProperty, ps, () => control.IsContentMovable = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsContentMovable<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.IsContentMovableProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsContentMovable<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.IsContentMovableProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsContentMovable<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._setEx(SukiUI.Controls.SukiSideMenuItem.IsContentMovableProperty, ps, () => control.IsContentMovable = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsTopMenuExpanded

/*ValueSetterGenerator*/
public static T IsTopMenuExpanded<T>(this T control, System.Boolean value) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._set(() => control.IsTopMenuExpanded = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsTopMenuExpanded<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.IsTopMenuExpandedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsTopMenuExpanded<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._setEx(SukiUI.Controls.SukiSideMenuItem.IsTopMenuExpandedProperty, ps, () => control.IsTopMenuExpanded = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsTopMenuExpanded<T>(this T control, IBinding binding) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.IsTopMenuExpandedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTopMenuExpanded<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.SukiSideMenuItem 
   => control._set(SukiUI.Controls.SukiSideMenuItem.IsTopMenuExpandedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsTopMenuExpanded<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.SukiSideMenuItem 
=> control._setEx(SukiUI.Controls.SukiSideMenuItem.IsTopMenuExpandedProperty, ps, () => control.IsTopMenuExpanded = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Icon

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, System.Object value) where T : SukiUI.Controls.SukiSideMenuItem 
=> style._addSetter(SukiUI.Controls.SukiSideMenuItem.IconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenuItem 
=> style._addSetter(SukiUI.Controls.SukiSideMenuItem.IconProperty, binding);


 // Header

/*ValueStyleSetterGenerator*/
public static Style<T> Header<T>(this Style<T> style, System.String value) where T : SukiUI.Controls.SukiSideMenuItem 
=> style._addSetter(SukiUI.Controls.SukiSideMenuItem.HeaderProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Header<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenuItem 
=> style._addSetter(SukiUI.Controls.SukiSideMenuItem.HeaderProperty, binding);


 // PageContent

/*ValueStyleSetterGenerator*/
public static Style<T> PageContent<T>(this Style<T> style, System.Object value) where T : SukiUI.Controls.SukiSideMenuItem 
=> style._addSetter(SukiUI.Controls.SukiSideMenuItem.PageContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PageContent<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenuItem 
=> style._addSetter(SukiUI.Controls.SukiSideMenuItem.PageContentProperty, binding);


 // SideDisplayTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> SideDisplayTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : SukiUI.Controls.SukiSideMenuItem 
=> style._addSetter(SukiUI.Controls.SukiSideMenuItem.SideDisplayTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SideDisplayTemplate<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenuItem 
=> style._addSetter(SukiUI.Controls.SukiSideMenuItem.SideDisplayTemplateProperty, binding);


 // IsContentMovable

/*ValueStyleSetterGenerator*/
public static Style<T> IsContentMovable<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiSideMenuItem 
=> style._addSetter(SukiUI.Controls.SukiSideMenuItem.IsContentMovableProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsContentMovable<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenuItem 
=> style._addSetter(SukiUI.Controls.SukiSideMenuItem.IsContentMovableProperty, binding);


 // IsTopMenuExpanded

/*ValueStyleSetterGenerator*/
public static Style<T> IsTopMenuExpanded<T>(this Style<T> style, System.Boolean value) where T : SukiUI.Controls.SukiSideMenuItem 
=> style._addSetter(SukiUI.Controls.SukiSideMenuItem.IsTopMenuExpandedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTopMenuExpanded<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.SukiSideMenuItem 
=> style._addSetter(SukiUI.Controls.SukiSideMenuItem.IsTopMenuExpandedProperty, binding);



}
