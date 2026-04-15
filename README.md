Dự án này thực hiện việc đọc giá trị nhiệt độ từ cảm biến LM35 thông qua vi điều khiển (Arduino), sau đó xử lý và hiển thị dữ liệu qua Serial Monitor hoặc ứng dụng trên máy tính.
Mục tiêu của dự án:
Hiểu cách hoạt động của cảm biến nhiệt độ
Thực hành đọc dữ liệu Analog từ Arduino
Xử lý và hiển thị dữ liệu nhiệt độ theo thời gian thực
Tính năng:
Đọc nhiệt độ từ cảm biến LM35
Hiển thị nhiệt độ theo °C
Gửi dữ liệu qua Serial (UART)
Có thể mở rộng nhiều kênh cảm biến
Dễ tích hợp với ứng dụng PC hoặc IoT
Phần cứng:
| STT | Tên thiết bị      | Số lượng | Ghi chú            |
|-----|------------------|----------|---------------------|
| 1   | Arduino Uno      | 1        | Vi điều khiển chính |
| 2   | LM35             | 1        | Cảm biến nhiệt độ   |
| 3   | Breadboard       | 1        | Test mạch           |
Hướng dẫn sử dụng
1. Kết nối phần cứng
LM35:
VCC → 5V Arduino
GND → GND
OUT → A0 (hoặc A1, A2 nếu nhiều cảm biến)
2. Nạp code
Mở Arduino IDE
Chọn đúng board và cổng COM
Upload code vào Arduino
3. Xem dữ liệu
Mở Serial Monitor
Baudrate: 9600
Quan sát nhiệt độ hiển thị theo thời gian thực
Cấu trúc thư mục
Arduino_LM35_TempMonitor/
│
├── firmware/
│   └── LM35_TempReader/
│       └── LM35_TempReader.ino
│
├── pc_app/
│   └── (Ứng dụng đọc Serial từ PC)
│
├── docs/
│   └── (Tài liệu, báo cáo)
│
├── libs/
│   └── (Thư viện sử dụng nếu có)
│
├── simulation/
│   └── (File mô phỏng Proteus)
│
└── README.md
Thành viên:
| STT | Thành viên       | MSSV      | Chức năng |
|:---:|:----------------:|:---------:|:---------:|
| 1   | Thái Gia Kỳ      | N23DCCI038| Admin     |
| 2   | Nguyễn Huy Hiệu  | N23DCCI024| Developer |