# EasyReport
EasyReport Development

<p align="center">
<img src="https://user-images.githubusercontent.com/50317129/62029819-97f9bc00-b21e-11e9-87e7-28c3dafc3951.png" width="256" height="256" alt="EasyReport" title="EasyReport">
</p>

일일이 쓰고 보내기 귀찮아서 직접 만든 보고서 메일 자동 작성 및 발송 프로그램

## EasyReport 2.3.0 RELEASE

2020.07.21 화요일 Update

+ 프로그램 실행 경로에 설정파일 없을 경우 기본 설정파일을 자동으로 생성하는 기능 추가
+ 생성 경로는 exe 실행파일 경로의 EasyReportConf.xml

## EasyReport 2.2.1 RELEASE

2020.07.21 화요일 Update

+ 메일 반복 발송 시 COM 객체 분리 오류로 인한 재발송 실패 현상 개선

## EasyReport 2.2.0 RELEASE

<p align="center">
<img src="https://user-images.githubusercontent.com/50317129/87893791-e2052e80-ca7b-11ea-9dd6-aed96a01f9e7.png" width="40%" height="40%" alt="EasyReport" title="EasyReport">
</p>

2020.07.20 월요일 Update

+ 설정 항목에서 SMTP 관련 항목 수정 가능하도록 개선
+ SMTP Host : 메일서버의 SMTP 호스트 도메인
+ SMTP Port : 메일서버의 SMTP 포트
+ SMTP SSL : 메일서버의 SSL 인증 사용 여부

## EasyReport 2.1.0 RELEASE

<p align="center">
<img src="https://user-images.githubusercontent.com/50317129/62346493-4f4d4600-b531-11e9-8ca2-8b64faf87174.png" width="40%" height="40%" alt="EasyReport" title="EasyReport">
</p>

2019.08.01 목요일 Update

+ 설정 xml 파일 프로그램 내에서 수정 가능하도록 관련기능 추가
프로그램 내부에서 Auto설정이 가능하도록 개선함으로써 사용자가 설정파일의 일부분을 더욱 쉽게 수정할 수 있도록 개선
입력한 설정은 Save 버튼을 누르는 즉시 반영

## EasyReport 2.0.0 RELEASE

2019.07.29 월요일 Update

+ 설정 xml파일 추가
주소록, Auto의 설정을 소스가 아닌 xml에서 읽어오기 때문에 사용자 단계에서의 수정이 가능하도록 수정

+ 일부 UI 개선
Control 위치와 크기 조절로 일부 UI의 가독성 개선

# INFO

개발언어 : `Visual Basic`

#### 지원 OS
+ Microsoft **Windows10**

#### NET Framework
+ **.NET Framework 4.7.2**

---
### 사용 방법
이 프로그램을 사용하기 위해선 **첨부된 Excel 양식의 보고서를 이용**하여 내용을 작성한다.

**EasyReportConf.xml**을 통해 주소록의 추가, 제거, 수정이 가능하다.
해당 xml은 프로그램의 설치경로와 같은 경로에 존재해야 한다.

**Auto**버튼을 누르면 수신자, 참조, 보고서 파일, 계정이 자동으로 입력된다.
해당 입력내용 역시 EasyReportConf.xml에서 커스터마이징이 가능하다.
Password의 경우, 빈 칸으로 두면 Auto 클릭 시 비밀번호는 입력되지 않는다. (다른 항목도 마찬가지)

**추가내용**에서 내용 외에 추가적으로 작성하고 싶은 내용을 기입한다.
해당 Control에 입력하는 내용은 기본 작성 내용이 끝나고 그 다음 내용에 추가됨

---
### 내용 예시
`해당 처리`된 내용은 Excel과 EasyReport의 내용에 맞게 변경됨

제목 : `YYYY-MM-DD` `A요일` 일일업무 보고입니다.

안녕하십니까.
`OO부` `OOO`(이름) `OO`(직책)입니다.
`YYYY-MM-DD` `A요일` 일일업무 보고입니다.

`1. 첫 번쩨 업무`
`세부 내용`

`2. 두 번째 업무`
`세부 내용`

`추가 내용`

이상입니다.

`OOO OO` 드림


---
### 주의사항
반드시 첨부된 **Excel 파일**을 이용할 것<br />
해당 Excel 파일의 보고서 내용과 연계되므로 양식이 달라지면 프로그램의 동작을 보장하지 못 함

Password와 같이 민감한 내용은 EasyReportConf.xml에 빈 칸으로 놔두면 **Auto** 클릭 시 해당 부분은 아무런 입력도 발생하지 않으며, 다른 항목 역시 동일하게 동작<br />
Password의 Base64와 같은 암호화를 구상하고 있었으나, DES의 경우 인터넷 몇 분만 찾아봐도 복호화가 가능하고, RSA를 쓸 정도로 노출도가 심하거나 범용적인 프로그램이 아니므로 노력대비 효용성이 낮다고 판단하여 개발하지 않음. 차후 RSA에 대한 이해도가 높아지면 다시 시도해볼 수도?

프로그램 구동 시, Excel이 잠깐 켜졌다가 꺼짐. Visible 속성을 변경만 해도 처리가 가능하지만, 어째서인지 간혹 Excel 프로세스가 정상적으로 종료되지 않는 문제가 발생함<br />
이는 해당 기능의 고질적인 문제로, Excel이 보일 경우 그냥 꺼주면 되지만, 보이지 않을 경우 일일이 프로세스를 종료해야 하므로 부득이하게 Excel의 호출을 보이도록 설정함

---

일일업무 보고 안 보내서 1년 가까이 안 쓰다가, 다시 쓰래서 저 밑에서 다시 꺼낸 프로그램<br />
먼지도 닦고 쓰면서 필요하거나 문제있던 부분을 개선함