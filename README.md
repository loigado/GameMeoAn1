# 🍕 Garfield Hungry: Catch The Food - 2D Casual Game
> **"Garfield Hungry"** là một trò chơi giải trí 2D nhẹ nhàng, nơi người chơi điều khiển nhân vật Garfield di chuyển để hứng những món ăn đang rơi xuống. Trò chơi đòi hỏi sự phản xạ nhanh tay và độ chính xác để đạt được điểm số cao nhất.

---

## 🎮 Hình ảnh trong Game (Screenshots)

| Giao diện Menu Chính | Trải nghiệm Gameplay | Giao diện Kết thúc (Game Over) |
|:---:|:---:|:---:|
| <img width="394" height="700" alt="menu" src="https://github.com/user-attachments/assets/6d9d81d2-79ed-4866-89e0-27121925a3e5" /> | <img width="395" height="702" alt="gameplay" src="https://github.com/user-attachments/assets/6b6291f9-b5fa-4d2f-b52b-6180a2508bab" /> | <img width="394" height="703" alt="Gameover" src="https://github.com/user-attachments/assets/020439a2-920b-433f-908b-f61a93d44070" /> |
| **Menu:** Bắt đầu, Đánh giá và Chia sẻ | **Play:** Hứng Pizza và theo dõi Mạng sống | **Over:** Hiển thị Điểm số & Kỷ lục |

---

## 🚀 Tính năng Kỹ thuật (Technical Features)

Dự án thể hiện khả năng xử lý các thành phần cốt lõi trong Unity 2D:

* **Xử lý Logic Vật lý & Collision:**
    * Sử dụng `OnTriggerEnter2D` để phát hiện va chạm giữa nhân vật và vật thể rơi.
    * Phân loại đối tượng bằng `Tag`. Nếu hứng đúng "Food" sẽ được cộng điểm, ngược lại sẽ bị trừ mạng.
* **Hệ thống Quản lý UI (State Management):**
    * Sử dụng `UIManager` để điều phối 3 trạng thái màn hình: Menu (0), Play (1), và Game Over (2) một cách mượt mà và tối ưu.
    * Cập nhật thời gian thực Điểm số và Hệ thống Mạng sống (3 mạng) lên màn hình người dùng.
* **Cơ chế Spawn Ngẫu nhiên:**
    * `SpawnManager` tự động tạo ra các loại thức ăn ngẫu nhiên từ danh sách `lsFoods` tại các vị trí trục X ngẫu nhiên (từ -2.5 đến 2.5).
    * Tích hợp bộ đếm thời gian (`timer`) và biến trạng thái `isStartGame` để kiểm soát nhịp độ rơi của vật thể.
* **Điều khiển & Animation:**
    * Nhân vật di chuyển linh hoạt theo vị trí chuột trên trục X (`Input.mousePosition`) thông qua `Camera.main.ScreenToWorldPoint`.
    * Tích hợp hệ thống Animator đa dạng: `isEat` (khi bắt đầu ăn), `isEatFull` (khi ăn thành công) và `isEatFuck` (khi lỡ nhịp/thất bại).
* **Lưu trữ Kỷ lục (Data Persistence):**
    * Sử dụng `PlayerPrefs` để lưu trữ và hiển thị Kỷ lục (Best Score), giúp lưu lại thành tích của người chơi ngay cả khi đã tắt game.

---

## 💻 Cấu trúc Mã nguồn (Project Structure)

Dự án được phân chia thành các file script rõ ràng để dễ dàng bảo trì và mở rộng:
* **`UIManager.cs`**: Xử lý toàn bộ logic bật/tắt các Panel giao diện, lắng nghe sự kiện Click nút Start/Restart và cập nhật UI.
* **`SpawnManager.cs`**: Quản lý vòng lặp thời gian và khởi tạo (Instantiate) các Prefab thức ăn vào môi trường game.
* **`TestPhysics.cs`**: Trái tim của Gameplay, chứa logic điều khiển nhân vật, xử lý va chạm vật lý, tính toán điểm số/mạng sống và kích hoạt Animation.

---

## 🛠️ Hướng dẫn Cài đặt & Chơi

1. **Môi trường:** Unity 2022+
2. **Cách cài đặt:** Clone dự án về máy, mở Unity Hub, chọn *Add project from disk* và trỏ vào thư mục vừa tải.
3. **Cách chơi:**
    * Dùng **Chuột** di chuyển ngang màn hình để điều khiển Garfield.
    * Cố gắng hứng các món thức ăn (Pizza...) để ghi điểm.
    * Tránh để lỡ thức ăn hoặc hứng vật phẩm sai để bảo toàn 3 mạng sống.
4. **Nền tảng hỗ trợ:** Dự án được tối ưu hóa để có thể Build trên Android, iOS hoặc WebGL.

---

## 👨‍💻 Thông tin Tác giả

* **Tác giả:** Lê Tấn Lợi
* **Đơn vị:** Sinh viên FPT Polytechnic và Học viện Green Academy
* **Kỹ năng:** Unity Developer, Software Engineer (Spring Boot, Vue.js, C#).
* **Liên hệ:** loiletan04@gmail.com
