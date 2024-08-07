# basic-aspnet-2024
IoT 개발자과정 ASP.NET 리포지토리

## 1일차
- 웹기술 개요
    - World Wide Web은 인터넷의 한 파트
    - Full-Stack
        - Front-end : 웹사이트 화면으로 사람들에게 보이는 부분 기술
        - Back-end : 웹사이트 뒤에서 동작하는 서버기술
        - Server-Operation : HW, OS, SW등 운영(클라우드), 도커, 쿠버네티스...

- 업무용 웹 사이트 참조
    - https://www.ecount.com/kr/ECK/ECK004M_CN.aspx

- Front-end(클라이언트)
    - HTML
    - CSS3
    - Javascript

- Back-end(서버)
    1. Java - Spring, Spring Boot, JSP, EJB ...
    2. Javascript - Node.js, Express ...
    3. Python - dJango, Flask, fastAPI ...
    4. C# - ASP.NET
    5. Ruby - Ruby on rails
    6. C - cgi, fasCGI ... 
    7. PHP

- 웹 개발
    - 프론트엔드 전부 + 백엔드 여러개 중 하나 + DB
    - 웹 브라우저에서 개발자도구(F12) 활용
    - VS Code 플러그인 - 프론트엔드
        - HTML Code Snippet
        - Live Server

- HTML5
    - XML(eXtensible Markup Lang)이 웹페이지 구성하기 위한 선행기술, 너무 복잡해서 간략화 시킨 것
    - Hyper Text Markup Language
    - 기본적으로 확장자 .html
    - Tip! lorem탭, 긴 샘플텍스트 생성
    - 기본태그(body에 사용)
        - h1 ~ h6 : 제목(마크다운 #, ##과 동일)
        - p : 일반문장
        - div, span : 그룹화 구분자, 아주 중요!(CSS 연계 디자인)
        - img : 이미지 표현
        - br : 한 줄 내리기(엔터)
        - hr : 가로선
        - 특수문자 : & ; 사이에 영문자로 표시(너무 많음!)
        - strong 또는 b : 볼드체
        - em : 이탤릭체
        - mark : 형광펜 효과
        - small, sub, sup : 글자작게, 아래첨자, 윗첨자
        - u, strike : 밑줄, 취소선
        - a : 웹페이지 링크(★)
        - ul, ol > li : 순서없는 목록, 순서있는 목록
        - table, tr, th, td : 테이블 만드는 태그
        - audio, video : 오디오, 비디오
        - object, embed : 객체 추가
    
    - HTML + CSS + Javascript
        - 내부 스타일, 외부 스타일, 인라인 스타일
        - 내부 스크립트, 외부 스크립트, 인라인 스크립트
    
    - 오류, 디버그
        - F12 개발자도구로 활용
    
    - 양식태그(body > form안에 사용 필수)
        - front-end 입력한 내용이 back-end로 보내기위한 관문
        - form을 반드시 사용
        - input
            - type="text" : 텍스트박스
            - type="password" : 비밀번호박스
            - type="button" : 일반버튼
            - type="submit" : 제출(★)
            - checkbox : 체크박스
            - radio : 라디오버튼
            - file : 파일 업로드
            - image : 이미지(img와 유사)
            - reset : 폼 내의 입력양식태그 값 초기화
            - hidden : 숨김값(유용하게 사용)
        - textarea : 여러 행 텍스트 입력
        - select, option : 콤보박스
        - fieldset : 그룹박스
        - submit 클릭 loopback(값 전달)발생
        - 값 전달 방법
            - GET : URL뒤 ?다음에 key=value&key=value ... 데이터 전달
            - POST : 화면 뒤로 숨겨서 데이터 전달하는 방식

    - 공간구분 태그
        - span - 한 줄로 공간구성
        - div - 행간으로 블록지정 공간구성

## 2일차
- HTML5
    - 시맨틱 웹 - 시맨틱 태그로 화면 구조를 잡는 웹구성 방식
        - header, nav, footer, aside, section, article... 구조태그(화면에 안나타남) 사용
        - 시맨틱 태그를 div로 바꿔도 똑같이 작용하기 때문에 요새는 많이 사용안함. 걷어내고 있는 추세
- CSS3
    - 웹 디자인 핵심, Cascading Style Sheets
    - 상단에서부터 <body>부터 하위 태그들에 계속해서 적용되는 스타일이라는 뜻
    - 선택자에게 주어지는 디자인 속성
    - 선택자(selector)
    - 속성(property)
    - 배경, 폰트...
    - 레이아웃
        - HTML만으로는 화면 레이아웃이 만들어지지 않음
        - 중앙정렬, 원트루, 고정바...
        - 반응형 웹(Responsive Web)
            - 메타태그 viewport를 사용하면 그때부터 반응형 웹이 됨!!
            ```html
            <meta name='viewport' content='width=device-width, initial-scale=1'>
            ```
            - @media 태그 : 디바이스 종류별로 CSS 따로 디자인 가능

## 3일차
- Javascript
    - 스크립트 언어
    - 웹 브라우저 주로 사용
    - 바닐라스크립트 : 완벽하게 기본에 충실한 자바스크립트
    - 기본적으로 클라이언트(웹 브라우저에서 프론트엔드에 표시) 베이스
    - Node.js : 자바스크립트로 백엔드를 구현(파이썬과 유사)
    - 특징
        - 자료형 선언이 없음, var로 변수선언
        - 인터프리터 언어(not Compile Lang)
        - 확장자 .js
        - 속도가 컴파일 언어에 비해 느림
        - VS Code도 자바스크립트로 만든 앱
        - 문장 끝 ;은 생략가능, but 최대한 쓸 것
        - 정수와 실수를 구분하지 않음
        - 0으로 나눠도 예외가 발생하지 않음
        - 파이썬과 동일하게 '," 모두 사용
        - 완전히 동일함을 비교하는 === 연산자
        - 변수선언 시 let(일반), var(지역변수), const(상수)
        - HTML 태그와 연계(DOM) 중요!

    - DOM(Document Object Model)!!
        - 실행순서!
        - HTML에 있는 모든 요소를 제어할 수 있음
        - HTML 애니메이션, 게임, 통신 모두 가능
        - 이벤트 (on- 으로 시작)
            - onload : 화면이 다 렌더링되면 그 다음 발생
            - onfocus : 객체에 마우스를 클릭해서 포커스가 가면 발생
            - onclick : 객체를 마우스로 클릭하면 발생
            - ondbclick : 더블클릭
            - onmousemove : 마우스를 이동하면 발생
            - onmouseover : 객체 위에 마우스가 올라가면 발생
            - onkeydown, onkeypress : 객체에서 키보드를 타이핑하면 발생
            - ...

    - jQuery
        - 자바스크립트 라이브러리
        - js를 매우 편리하게 사용할 수 있도록 도와주는 서포트 라이브러리
        - 순식간에 웹개발 업계를 장악했던 라이브러리
        - 사용빈도가 줄고는 있지만 아직도 80% 웹사이트가 사용 중
        - js 파일 다운로드 후 사용하거나
        - CND 링크를 사용하는 방법(추천)

## 4일차
- HTML + CSS + js(jQuery) 응용
    - jQuery 응용
        - javascript와 jQuery를 혼용해도 상관없음
        - jQuery로 코딩 편할 때와 javascript가 편할 때도 있음
    - Bootstrap
        - 오픈소스 css 프레임워크
        - 트위터 블루프린트 -> 부트스트랩
        - 현재 전세계에서 가장 각광받는 프레임워크 중 하나
        - CSS를 동작시키기 위해서 Javascript도 포함
        - 소스 다운로드 받아서 사용(1), CDN으로 링크만 사용(2)
            - 제한된 네트워크에서는 1번
            - 인터넷에서 항상 연결된 환경에서는 2번이 편리
        - 핵심!
            - Bootstrap은 화면사이즈를 12등분!
                - 12를 넘어서면 디자인이 깨짐!!!
            - container 밑에 마치 table처럼 div를 구분해서 사용
            - container > row > col div 태그 클래스 정의
        - 부트스트랩 학습에 시간을 들이는게 아님. Copyleft가 정석!
            - https://getbootstrap.com/docs/5.3/getting-started/introduction/ 참조
            - https://getbootstrap.com/docs/5.3/examples/ 스니펫을 활용 추천
        - 무료 테마(템플릿)가 아주 잘되어 있음
            - https://startbootstrap.com/
        
    - 웹페이지 클로닝
        - 핀터레스트 타입 + 부트스트랩 웹페이지 만들기(진행중)

## 5일차
- HTML + CSS + js(jQuery) 응용
    - 웹페이지 클로닝
        - 핀터레스트 타입 + 부트스트랩 웹페이지 만들기(완료)

            https://github.com/guswlrla/basic-aspnet-2024/assets/158007465/4e380e75-c152-4922-9afe-80a3d39eecc1

        - Codehal 유튜버 로그인 웹페이지 튜토리얼 따라하기

            <img src="https://raw.githubusercontent.com/guswlrla/basic-aspnet-2024/main/images/an001.png" width="730">

        - Codehal 슬라이더 애니메이션 웹페이지 튜토리얼 따라하기

## 6일차
- HTML + CSS + js(jQuery) 응용
    - 웹페이지 클로닝
        - Codehal 슬라이더 애니메이션 웹페이지 튜토리얼 따라하기 (완료)

            https://github.com/guswlrla/basic-aspnet-2024/assets/158007465/a999dbc2-7612-4f41-a987-9af7b00bc02d

    - 개인 웹페이지 클로닝

        https://github.com/guswlrla/basic-aspnet-2024/assets/158007465/b8c909b0-6717-4aa6-b5db-38fd301cbcde

## 8일차
- ASP.NET
    - 웹퍼블리시 - HTML, CSS, Javascript만 가지고 웹페이지 개발(디자인)
    - 프론트엔드 개발자 - 웹퍼블리시가 만든 웹페이지에 백엔드와 연계를 해서 실제 동작하는 페이지 개발(개발자)
        - json, 백엔드, DB 전반적인 개발 지식

    - ASP.NET 역사
        - 1990년대 MS가 웹 서버기술로 ASP(Active Server Page) -> JSP(Java Server Page)
        - ASP는 .NET으로 된 언어가 아닌, VBScript를 사용. 확장자(.asp)
        - 스파게티 코드 - HTML + CSS + JavaScript + VBScript 합쳐서 만든 웹페이지
            - 프론트엔드 + 백엔드 소스가 모두 한페이지에...
            - 다만, 현재 프론트엔드도 백엔드 소스가 일부는 포함되어 있음
        - 많이 사용되었지만 유지보수 어렵고, 성능이 나쁘고 ...

        - 2000년대 MS가 .NET Framework를 발표
        - C#, VB.NET, C++.NET 등의 새로운 언어를 배포, 여기에 맞춰서 웹 서버기술을 다시 만듦 -> ASP.NET(.aspx)
        - 윈폼 개발하는 것처럼 웹개발을 할 수 있었음
        - 초창기에 스파게티 코드를 거의 그대로 사용, 성능 안좋음...
        - 2009년 ASP.NET MVC(Model View Controller 디자인패턴) 공표, 성능은 좋아짐
        - but, 윈도우에서만 동작
        - 모든 OS플랫폼에서 동작할 수 있는 .NET Core를 재출시
        - 거기에 웹 서버기술을 또 다시 만듦 -> ASP.NET Core
        - ASP.NET은 C#이 아닌 다른 .NET 언어로도 개발가능. 그 중에서 C#을 사용

    - .NET Core(현재는 .NET 9.0, Core라는 이름은 사용안함)의 장점
        - 빠르고 오픈소스
        - **크로스 플랫폼**, OS에 종속받지 않음
        - 성능 좋음
    
    - ASP.NET 종류
        - ~~ASP.NET Webforms - 2000년도 초반에 나오다가 시작된 웹사이트 개발기술~~
        - **ASP.NET Core 웹앱(MVC) - 가장 기본적인 프론트엔드(HTML, CSS, JS .html) + 백엔드(C# .aspx.cs) 웹개발**
        - **ASP.NET Core 웹 API - 데이터포털, 네이버, 카카오, 영화 API 사이트를 만드는 백엔드(프론트엔드가 없어서 화면이 없음)**
        - Js(Vue, Angular, React) 프론트엔드 + ASP.NET Core 백엔드
        - ~~Edge용 웹 드라이버 테스트 - 엣지 브라우저에 종속된 테스트용~~
        - ASP.NET Core gRPC 서비스 - 고성능 원격프로시저호출(스트리밍 호출) 서비스
        - Blazor - Js 프론트엔드를 따라서 C# 컴포넌트 기반으로 개발하는 웹개발 방식 웹사이트 개발
        - Razor - 프론트엔드 개발에 C# 코드가 특화돼서 사용되는 웹사이트 개발방식
        - .NET Aspire - Blazor 프론트엔드 + Redis + 웹 API 백엔드

    - 참조사이트
        - https://learn.microsoft.com/ko-kr/aspnet/core/?view=aspnetcore-3.1
        - https://github.com/dotnet
        - https://mixedcode.com/
        - https://github.com/gilbutITbook/006824

    - ASP.NET Core 웹앱(Model-View-Controller)
        - 현재 기본적인 웹개발의 가장 표준
        - Java 계열도 Spring (Boot) MVC로 개발
        - MVC 개념도

            <img src="https://raw.githubusercontent.com/guswlrla/basic-aspnet-2024/main/images/an002.png" width="730">

        - 프론트엔드가 예전엔 스파게티코드가 심했다면, 현재는 스파게티코드가 최소화 되어있음. (SpringBoot, Python flask든 모두 동일)
        - IIS Express Server - VS에서 ASP.NET 웹사이트를 운영하는 개발용 웹서버
        - index.* - 웹사이트 가장 대문되는 페이지이름
        - 파일 저장시 핫다시로드(HotReload) 체크
        - @로 시작하는 C# 구문. Tag helper, Html helper로 HTML 구문 내에 C# 코드를 적어서 활용하는 방법 = Razor구문
        - Action == HTML에서 form태그 내 submit버튼 클릭! / 링크를 클릭하는 것, 윈앱에서 
        - 액션이 발생한 이후 처리하는 메서드의 결과를 ActionResult
        - 콘솔 서버로그 잘 확인할 것, 프로세스가 종료되면 웹사이트가 실행안됨

    - 데이터베이스 연동방법
        - DB first - 가장 전통적인 DB 연동방식. DB 설계, DB구축, C#과 연동
        - Code first - 최근 트렌드가 되는 DB 연동방식. C# 엔티티 클래스 작성, DB연결 설정 후 실행하면 DB에 테이블이 생성
        - EntityFramework를 사용하면 아주 쉽게 구축가능
    
    - EntityFramework(Core) 설치
        - Microsoft.EntityFrameworkCore
        - Microsoft.EntityFrameworkCore.Tools
        - Microsoft.EntityFrameworkCore.SqlServer
    
    - Code first 구현순서
        - ASP.NET 프로젝트 생성
        - EF 패키지 설치
        - 엔티티 클래스 작성
        - appsettings.json에 DB연결문자열 추가
        - Data/ApplicationDbContext.cs 중간연결 클래스 생성
        - Program.cs Services 내에 DbContext 종속성을 주입
        - Nuget 패키지 관리자 > 패키지 관리자 콘솔 실행
            ```shell
            PM> add-Migration 마이그레이션명
            Build started...
            Build succeeded.
            ...
            PM> Update-Database
            ...
            Done.
            ```
    - 브라우저 실행 시 NET::ERR_CERT_INVALID 연결 비공개 설정이 안돼 화면이 나타나지 않는 경우
        - 브라우저 화면 클릭, thisisunsafe 입력 엔터

## 9일차
- ASP.NET Core MVC
    - MVC 리뷰
        - Model은 개발자가 따로 만듦
        - View, Controller 폴더는 미리 만들어짐
        - 웹 브라우저에서 접근할 페이지를 만들려면(작업순서)
            1. 해당 컨트롤러를 생성
            2. 뷰를 같이 생성할지 나중에 따로 만들지 선택
            3. 컨트롤러 이름과 동일한 뷰 폴더, 메서드 이름과 동일한 cshtml 페이지가 생성(이름이 다르면 안됨!)
            4. 컨트롤러에 모델에 DB와 연결될 내용을 작성
            5. 모델 내용을 뷰로 리턴 

- ASP.NET Core 포트폴리오 웹사이트, MyPortfolio
    1. Visual Studio에서 ASP.NET Core 웹앱(MVC) 프로젝트 생성
    2. 부트스트랩 템플릿 사이트, 알맞은 템플릿 다운로드
    3. wwwroot 폴더 밑에 템플릿 html, css, js, 이미지 등 위치
    4. 템플릿 페이지에 공통적인 부분(Header, Bottom)은 _layout.cshtml에 위치
    5. 중간에 페이지마다 변경되는 부분은 각 Views 밑에 포함
    6. _layout.cshtml에 공통부분 옮기기
    7. index.cshtml에 index.html에서 공통부분 외 영역 옮기기
    8. index.cshtml 내용 수정
    9. ResumeController.cs 생성, DB 관련된 설정이 없으면 모델, 뷰를 만들기 어려움
    10. Resume 란 폴더가 View 아래에 만듦. Index.cshtml
    11. resume.html에 네비게이션 아래 변경부분만 복사해서 index.cshtml에 붙여넣기
    12. Project, Contact도 동일하게 적용
    13. Code First 방식으로 Board 테이블 생성
    14. NuGet 패키지에서 Microsoft.EntityFrameworkCore 패키지 검색, 설치
    15. Microsoft.EntityFrameworkCore.Tools 검색, 설치
    16. Microsoft.EntityFrameworkCore.SqlServer 검색, 설치
    17. Models/Board.cs로 엔티티 클래스 생성
    18. appsettings.json에 DB 연결문자열 추가
    19. Data/AppDbContext.cs 생성
    20. Program.cs에 DbContext 종속성 주입
    21. NuGet패키지 관리자 콘솔 > Add-Migration, Update-Database 진행
    22. _layout.cshtml Board 링크 수정
    23. /Controller/BoardController.cs를 생성(모델, 뷰 연결)
        - Entity Framwork를  사용하며 뷰가 포함된 MVC컨트롤러

        <img src="https://raw.githubusercontent.com/guswlrla/basic-aspnet-2024/main/images/an003.png" width="500">

## 10일차
- ASP.NET Core 포트폴리오 웹사이트, MyPortfolio
    1. Board.cs 멤버속성 ModeDate -> ModDate
        - BoardController.cs에서 ModeDate -> ModDate 변경
        - Views/Board/*.cshtml ModeDate -> ModDate 변경
    2. ASP.NET Core 템플릿으로 만들어주는 CRUD(Insert, Select, Update, Delete)
    3. 테이블 삭제, 재생성
    4. 게시판 관련된 화면 수정작업
        - Views/Board/Index.cshtml 게시판 리스트화면 수정
        - Index.cshtml 테이블 틀 변경, 삭제, 수정, 상세버튼 삭제
        - Models/Board.cs에 테이블 한글이름 추가 DisplayName()
        - Views/Board/Details.cshtml 부트스트랩 적용
        - 수정, 삭제 등 버튼 디자인적용
        - Views/Board/Create.cshtml 부트스트랩 적용

    5. SSMS에서 Board테이블 Hit, RegDate, ModDate Null허용으로 변경
    6. 웹사이트 동작 순서
        1. https://localhost:7109/Board/Create 링크오픈
        2. BoardController -> Create 액션메서드 발동
        3. Submit -> BoardController -> Create 액션메서드 발동
        4. Create 액션 메서드 내 로직처리 DB에 데이터 입력
        5. Models/Board.cs ModDate를 DateTime -> DateTime?으로 변경
        6. Edit 동일, Create.cshtml 내용을 그대로 복붙. 단, asp-action="Edit"로 변경!!

## 11일차
- ASP.NET Core 포트폴리오 웹사이트, MyPortfolio
    1. EntityFramework로 SQL 사용없이 DB 핸들링
        - DbContext.Add(삽입), Update(수정), Remove(삭제) 기능 존재
        - 위의 명령을 실행 후 DbContext.SaveChangesAsync() 실행해서 실제 DB 반영
        - ToListAsync(), FirstOrDefaultAsync()는 SELECT로 트랜잭션이 발생x, 그래서 SaveChangesAsync()를 실행x
    2. 글 조회수 올리기
    3. 게시글 삭제
        - _layout.cshtml의 @await RenderSectionAsync("Scripts", required: false) 이 각 페이지에 필요시 스크립트 영역을 만들어써라는 의미
        - AJAX 삭제는 나중에 다시!!
    4. 페이징
        - 웹사이트에서 가장 중요한 기능 중 하나
        - 한 페이지에 표시할 수 있는 글의 수를 제한
        - 스크롤 페이징, 번호 페이징
        - 번호 페이징
            1. BoardController.cs Index() 액션메서드 내 FromSql()로 변경(비동기 적용 안됨, 비동기 부분 제거)
            2. 페이징용 쿼리 작성
                
                ```sql
                SELECT *
                  FROM (
                        SELECT ROW_NUMBER() OVER (ORDER BY Id DESC) AS rowNum
                            , Id
                            , Name
                            , UserId
                            , Title
                            , Contents
                            , Hit
                            , RegDate
                            , ModDate
                        FROM Board
                    ) AS base
                 WHERE base.rowNum BETWEEN 1 AND 10; -- 1과 10에 10씩 더하면 다음 페이지 조회 쿼리
                ```
            3. Index()내 로직 수정
            4. Views/Board/Index.cshtml 화면코드 수정

                https://github.com/user-attachments/assets/63297cbf-1392-4bca-82a7-9fa2bfaddbd6

    5. 검색
        - FromSqlRaw() 메서드 변경
        - html 링크에 ?page=1&search=검색어 추가 
    6. HTML 에디터
        - Markdown 에디터
        - simplemde(https://simplemde.com/)
        - _layout.cshtml에 js, css 링크만 추가
        - 실제 사용페이지에서 특정 js만 실행
        - Create.cshtml, Edit.cshtml은 동일하게 작업
        - NuGet패키지 Westwind.AspNetCore.Markdown 검색

        <img src="https://raw.githubusercontent.com/guswlrla/basic-aspnet-2024/main/images/an004.png" width="600">

## 12일차
- ASP.NET Core 포트폴리오 웹사이트, MyPortfolio
    1. 삭제로직 수정
        1. BoardController.cs 사용x -> BoardRestController.cs 다시 생성
        2. /Views/Details.cshtml jQuery를 작업 팝업
        3. /Board/Index로 화면 전환
    2. 회원가입, 로그인, 권한
        1. /Models/User.cs 클래스 생성
        2. User클래스와 Board클래스간 관계형성(virtual)
        3. AppDbContext.cs에 User DBSet 추가
        4. Add-Migration, Update-Database 실행 -> DB 생성
        5. Program.cs 로그인 세션 설정
        6. _layout.cshtml 로그인/로그아웃 메뉴 추가
        7. HomeController.cs Login/Logout 액션메서드 작성
        8. Login() 액션메서드 마우스오른쪽 버튼 뷰생성 Login.cshtml
        9. bootstrap 사이트에서 예제 파일 다운로드
        10. sign-in 폴더 내 index.html. sign-in.css Static경로(wwwroot) 복사
        11. Login.cshtml을 위의 파일 참조해서 수정
        12. HomeController.cs 에 Register() 액션메서드 작성
        13. Register.cshtml 회원가입 페이지 생성

## 13일차
- ASP.NET Core 포트폴리오 웹사이트, MyPortfolio
    1. 회원가입 계속...
        1. Register.cshtml에 asp-for등 C# Razor tag로 변경
        2. HomeController.cs Register Post 메서드 작성
        3. Login.cshtml에 C# Razor tag로 변경
        4. HomeController.cs Login Post 메서드 작성
        5. Logout Get메서드 추가

    2. 게시판 글 오류 수정
        1. Board.cs 에 있는 Name, UserID를 삭제, User?로 변경, UserName을 virtual 추가
        2. BoardController.cs 있는 Board 클래스와 관련된 변수도 삭제
        3. Views/Board/*.cshtml Name, UserID를 삭제, 변경
        4. BoardController.cs 게시글 리스트 쿼리 변경
        5. Views/Board/*.cshtml 수정
        6. BoardController.cs에 Create Post 메서드에 사용자데이터 추가수정

    3. 프로젝트 파일업로드
        1. Project.cs 모델 생성
        2. AppDbContext.cs에 DbSet 추가
        3. Add-Migration, Update-Database
        4. ProjectController, View 생성
        5. Views/Project/Create.cshtml 수정
        6. ProjectController, Create Post 메서드 수정

## 14일차

