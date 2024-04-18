# C# Project
##.net 프레임 워크 사용해서 윈도우 폼 만들기  
[설문조사 실행파일](https://github.com/2018130/firstProjectCSharp/blob/main/obj/Debug/firstProjectCSharp.exe)

## 1. 목차
 - 로그인 화면
 - 회원가입
 - 물품관리
 1. 관리자용
 2. 버튼들


## 2. 로그인화면 
![KakaoTalk_Photo_2023-06-11-01-21-44 003](https://github.com/2020864003/2023OOP/assets/128778304/77994954-359e-4a41-9141-f311867ada29)
 - 일반인용 로그인과 관리자용 로그인 버튼
 - 회원가입 페이지 만들기
 - 유저정보, 관리자 정보가 저장됨

### 2.1 로그인화면 코드
``` C#
 GoodList questionList; //다음폼에서 띄울 설문 리스트 저장

    enum ELoginType //로그인할때 사용자 타입 선언
    {
        MANAGER,
        COMMON,
    } 
    public static class UserInfo //유저 정보 저장
    {
        public static Dictionary<string, string> IDAndPassward = new Dictionary<string,string>();
    }
    public static class ManagerInfo //관리자 정보 저장
    {
        public static Dictionary<string, string> IDAndPassward = new Dictionary<string,string>();
   }
```
![image](https://github.com/2020864003/2023OOP/assets/128778304/2f014ca8-87b0-46c3-bbb7-0180ffee4f63)
※ static class를 form클래스보다 앞에 선언하면 에러 


## 3.회원가입
![image](https://github.com/2020864003/2023OOP/assets/128778304/666c47e5-0d50-4564-8c7c-76f8d057174d)
 - 회원가입 버튼을 눌렸을 때, radio button로 일반유저와 관리자용 나누기
 - 아이디 중복확인하기
 - 회원가입 후, 다시 로그인 페이지 넘어가기

![image](https://github.com/2020864003/2023OOP/assets/128778304/ef7b9bfa-31b8-4be1-adba-c877a10f7d10)
 - 회원가입, ID 중복 확인 후, ‘사용 가능합니다’ 창을 띄운다

![image](https://github.com/2020864003/2023OOP/assets/128778304/c7b1e44f-d1bb-414a-950f-1fb819c7b79e)
 - 만약, 아이디 or 비밀번호를 다 안 적은 상태 또는 아이디가 중복이면, ‘아이디와 비밀번호 확인해주세요' 창 띄우기


### 3.1 회원가입 코드
``` C#
 Form4 logInForm;

   bool IdUnique = false;

   public SignUp()
    {
        InitializeComponent();
    }
    public SignUp(Form4 form)
    {
        InitializeComponent();
        logInForm = form;
    }
```
![image](https://github.com/2020864003/2023OOP/assets/128778304/8baf1fbb-2a53-4981-a76f-4382256e5e31)
- 생성자 오버로딩 해서 해당 폼의 인스턴스 생성 시 돌아갈 윈도우 폼 저장

- Id가 중복일때 예외처리를 위한 IdUnique변수 선언


## 4. 물품관리

### 1. 관리자용
![image](https://github.com/2020864003/2023OOP/assets/128778304/4d4fb707-d6ac-41db-8232-fd888d8c8d10)
 - 관리자용으로 로그인 했을 경우 => 물품 추가 버튼이 있는 창이 뜸!
![image](https://github.com/2020864003/2023OOP/assets/128778304/9229c96c-9938-488b-84a1-af76d70a6d2a)
 - 물품 추가 버튼을 눌리면 => 관리창이 띄워 지면서 물품 추가 할 수 있도록 한다
![image](https://github.com/2020864003/2023OOP/assets/128778304/ef485673-7fdc-4d42-9638-74ca3978016f)
![image](https://github.com/2020864003/2023OOP/assets/128778304/3942774b-dbfe-4a2f-bee6-2209f3cdd06a)
![image](https://github.com/2020864003/2023OOP/assets/128778304/1095742d-b577-4790-88d1-dfce192ee3ad)
 - Textbox: Textbox 사용용도는 입고된 물품의 개수를 적을 공간임. 
![image](https://github.com/2020864003/2023OOP/assets/128778304/a8dd756e-963f-411f-9409-d147e9075fd6)
 - Checkbox: Checkbox 사용 용도는 주문한 물품이 입고가 되었는지 사용용도로 쓸 수 있음
![image](https://github.com/2020864003/2023OOP/assets/128778304/71fad44a-a0b8-47d5-828f-cdabfe17bd9d)
-Radio Button: Radio Button 용도는 물품이 있는가? 없는가? 에 사용하는 용도

### 2. 일반유저 (사용자)
![image](https://github.com/2020864003/2023OOP/assets/128778304/7ce3c709-0f0f-46e9-93f8-4d8eb26ba270)
 - 관리자가 물품 등록하면 => 일반유저(사용자용)에서 재고가 얼마나 있는지 확인 가능.













