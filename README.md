# 🧪 Лабораторная работа №6

![Интерфейс](Images/3_1.png)

---

## 3.1 — Скриншот интерфейса

![Интерфейс](Images/0.png)

---

## 🔧 1. Сцена

- На сцене размещены три куба: `Cube1`, `Cube2`, `Cube3`.
- У всех кубов компонент **Rigidbody** с отключённой гравитацией (`useGravity = false`).
- Создан **UI Canvas** с элементами:
  - Три кнопки: `CubeButton_1`, `CubeButton_2`, `CubeButton_3` — расположены под соответствующими кубами.
  - Текст по центру: **"Guess the Cube"**.
  - Текст **"You Win"** — изначально отключён.

---

## 💻 2. Скрипт `CubeGameController.cs`

Подключены:
- Rigidbody кубов.
- Объект `YouWinText`.

### 🔹 Переменные:
- `correctCubeIndex` — индекс правильного куба (от 1 до 3).

### 🔹 Метод `SelectCube(int index)`:

```csharp
using UnityEngine;

public class CubeGameController : MonoBehaviour
{
    public Rigidbody cube1, cube2, cube3;
    public GameObject winText;
    public int correctCubeIndex = 1; // от 1 до 3

    public void SelectCube(int index)
    {
        Debug.Log("Pressed: " + index); 

        cube1.useGravity = index != 1;
        cube2.useGravity = index != 2;
        cube3.useGravity = index != 3;

        if (index == correctCubeIndex)
            winText.SetActive(true);
    }
}
