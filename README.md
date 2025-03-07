"# Decorator" 
Dùng kế thừa (Tĩnh - Compile-time)
Nhược điểm
Nếu muốn thêm nhiều topping khác (Caramel, Socola, Mật ong...), bạn phải tạo nhiều class kế thừa, rất rối.
Không thể linh hoạt thay đổi topping khi chạy chương trình.
Ưu điểm của mẫu Decorator:
•	Mở rộng hành vi của một đối tượng mà không cần tạo một lớp con mới
•	Thêm hoặc xóa trách nhiệm khỏi một đối tượng lúc runtime
•	Kết hợp nhiều hành vi bằng cách bao bọc một đối tượng vào nhiều decorator
•	Tuân thủ nguyên tắc single Resoinsibility. Có thể chia một lướp monolithic triển khai nhiều biến thể hành vi thành nhiều lớp nhỏ hơn
