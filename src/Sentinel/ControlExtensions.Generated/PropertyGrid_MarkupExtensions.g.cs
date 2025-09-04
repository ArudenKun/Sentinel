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
public static partial class PropertyGrid_MarkupExtensions
{
//================= Properties ======================//
 // Item

/*ValueSetterGenerator*/
public static T Item<T>(this T control, System.ComponentModel.INotifyPropertyChanged value) where T : SukiUI.Controls.PropertyGrid 
=> control._set(() => control.Item = value!);

/*BindFromExpressionSetterGenerator*/
public static T Item<T>(this T control, Func<System.ComponentModel.INotifyPropertyChanged> func, Action<System.ComponentModel.INotifyPropertyChanged>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.PropertyGrid 
   => control._set(SukiUI.Controls.PropertyGrid.ItemProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Item<T>(this T control,System.ComponentModel.INotifyPropertyChanged value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.PropertyGrid 
=> control._setEx(SukiUI.Controls.PropertyGrid.ItemProperty, ps, () => control.Item = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Item<T>(this T control, IBinding binding) where T : SukiUI.Controls.PropertyGrid 
   => control._set(SukiUI.Controls.PropertyGrid.ItemProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Item<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.PropertyGrid 
   => control._set(SukiUI.Controls.PropertyGrid.ItemProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Item<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.ComponentModel.INotifyPropertyChanged> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.PropertyGrid 
=> control._setEx(SukiUI.Controls.PropertyGrid.ItemProperty, ps, () => control.Item = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Instance

/*ValueSetterGenerator*/
public static T Instance<T>(this T control, SukiUI.Controls.InstanceViewModel value) where T : SukiUI.Controls.PropertyGrid 
=> control._set(() => control.Instance = value!);

/*BindFromExpressionSetterGenerator*/
public static T Instance<T>(this T control, Func<SukiUI.Controls.InstanceViewModel> func, Action<SukiUI.Controls.InstanceViewModel>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : SukiUI.Controls.PropertyGrid 
   => control._set(SukiUI.Controls.PropertyGrid.InstanceProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Instance<T>(this T control,SukiUI.Controls.InstanceViewModel value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.PropertyGrid 
=> control._setEx(SukiUI.Controls.PropertyGrid.InstanceProperty, ps, () => control.Instance = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Instance<T>(this T control, IBinding binding) where T : SukiUI.Controls.PropertyGrid 
   => control._set(SukiUI.Controls.PropertyGrid.InstanceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Instance<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SukiUI.Controls.PropertyGrid 
   => control._set(SukiUI.Controls.PropertyGrid.InstanceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Instance<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, SukiUI.Controls.InstanceViewModel> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : SukiUI.Controls.PropertyGrid 
=> control._setEx(SukiUI.Controls.PropertyGrid.InstanceProperty, ps, () => control.Instance = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Item

/*ValueStyleSetterGenerator*/
public static Style<T> Item<T>(this Style<T> style, System.ComponentModel.INotifyPropertyChanged value) where T : SukiUI.Controls.PropertyGrid 
=> style._addSetter(SukiUI.Controls.PropertyGrid.ItemProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Item<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.PropertyGrid 
=> style._addSetter(SukiUI.Controls.PropertyGrid.ItemProperty, binding);


 // Instance

/*ValueStyleSetterGenerator*/
public static Style<T> Instance<T>(this Style<T> style, SukiUI.Controls.InstanceViewModel value) where T : SukiUI.Controls.PropertyGrid 
=> style._addSetter(SukiUI.Controls.PropertyGrid.InstanceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Instance<T>(this Style<T> style, IBinding binding) where T : SukiUI.Controls.PropertyGrid 
=> style._addSetter(SukiUI.Controls.PropertyGrid.InstanceProperty, binding);



}
