# ✨ HoverAnimationButton (WPF 커스텀 컨트롤)

`HoverAnimationButton`은 WPF에서 XAML `Storyboard`를 활용하여 현대적인 마우스 오버 애니메이션을 제공하는 사용자 정의 버튼 컨트롤입니다. 마우스를 올리면 부드럽게 확대되고, 콘텐츠가 위로 약간 이동하며, 그림자 효과가 적용됩니다.

## 🧩 주요 기능

- 마우스 오버 시 부드러운 **확대 애니메이션**
- 콘텐츠가 살짝 위로 이동하는 **Y축 변환**
- 입체감을 주는 **DropShadowEffect**
- `TemplateBinding`을 활용한 유연한 스타일링
- 순수 XAML 기반 구현 (코드 비하인드 없음)

## 💡 사용 예시

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

> CornerRadius는 HoverAnimationButton에 DependencyProperty로 정의되어 있어야 합니다.

## 📐 템플릿 구성

- **Border**
    - 배경 및 테두리 렌더링
    - 호버 시 확대 효과 적용

- **ContentPresenter**
    - 버튼의 콘텐츠 표시
    - 콘텐츠가 위로 살짝 올라가는 애니메이션 적용

- **DropShadowEffect**
    - 부드러운 그림자 효과
    
- **Storyboard**
    - 마우스 오버 진입/이탈 시 애니메이션 처리

## 🚀 애니메이션 상세
### 마우스 오버 시 (`IsMouseOver = true`)
- borderScale → ScaleX, ScaleY → `1.05`
- contentTransform → Y 오프셋 → `-2`

### 마우스 벗어날 때
- borderScale → `1.0`으로 복귀
- contentTransform → Y 오프셋 → `0`

전환 애니메이션은 모두 0.2초로 자연스럽게 처리됩니다.

## 📎 참고 사항
컨트롤은 `Button` 또는 `ContentControl`을 상속해야 합니다.

`CornerRadius`를 사용하려면 별도의 DependencyProperty를 정의해 주세요.

`ResourceDictionary`에 포함시켜 애플리케이션 전반에서 재사용할 수 있습니다.