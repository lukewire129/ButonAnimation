# ✨ HoverAnimationButton (WPF Custom Control)

`HoverAnimationButton` is a custom WPF control that provides a modern hover animation using XAML `Storyboard`. When the user hovers over the button, it smoothly scales up, slightly moves the content upward, and displays a subtle drop shadow.

## 🧩 Features

- Smooth **scale-up animation** on mouse hover
- Slight **vertical content lift** using `TranslateTransform`
- **Drop shadow effect** for depth and modern look
- Fully customizable via `TemplateBinding`
- Pure XAML implementation (no code-behind required)

## 💡 Usage

```xml
<local:HoverAnimationButton
    Width="160"
    Height="48"
    Background="#007ACC"
    BorderBrush="Transparent"
    Foreground="White"
    CornerRadius="6"
    Content="Hover Me!" />
```
> CornerRadius must be defined as a DependencyProperty in the HoverAnimationButton control.

## 📐 Template Overview
- **Border**
  - Hosts the main background and border visuals
  - Applies the scale transform during hover

- **ContentPresenter**
  - Displays the button content
  - Applies a vertical transform to slightly lift the content

- **DropShadowEffect**
  - Adds a soft shadow for depth

- **Storyboard**
  - Animates hover enter/exit actions smoothly

## 🚀 Animation Details
### On Hover (`IsMouseOver = true`)
- `borderScale` → ScaleX and ScaleY animate to `1.05`
- `contentTransform` → Y offset to `-2`

### On Hover Exit
- Reset `borderScale` back to `1.0`
- Reset `contentTransform` Y offset to `0`

All transitions take 0.2 seconds for a smooth feel.

## 📎 Notes
- The control must inherit from `Button`, `ContentControl`, or similar.
- Make sure `HoverAnimationButton` has a `CornerRadius` property if you want to support rounded corners.
- This style can be reused across the application by adding the `ResourceDictionary`.

https://github.com/user-attachments/assets/2a7aeb32-d45f-4cf9-b678-fb8b3875f1a6

## 🇰🇷 [한국어 README 보기](README.ko.md)

