#DeadlyTrade
[ DeadlyTrade PreBeta 버전이 업데이트 안내. ] :: 2020.01.10 Pre-Beta Version.

![DeadlyTrade_Maifunction_Explanation](https://user-images.githubusercontent.com/11026168/72128670-0094b980-33b7-11ea-9c95-1c8e7edbf23c.png)

​

자세한 내용은 https://discord.gg/ryjUA7r 의 Download 채널을 참고 바랍니다!

​

Still sane exile? Finally we launch DeadlyTrade PreBeta Ver.

you can check download channel now.

​

프리 베타 버전은 알려진 버그들이 있습니다만, 2일 이내에 수정될 것입니다.

This beta pre release version has known bugs. But it will be fix within 2days.

​

​

#패스오브엘자일, #PathOfExile, #애드온, #Addon, #매크로, #Macro, #트레이드, #Trade, #데들리트레이드, #DeadlyTrade


# DeadlyTrade
DeadlyTrade with ExileDirection for POE

{ 2019.09.11 DeadlyTrade 1.0.3.8 }

안녕하세요. 데들리크러쉬 입니다.
3.8 역병 리그는 잘 진행하고 계신지요? 스탠에서 하고 계신분들도 강해지고 계신지요?

응원해주시고 격려해주신 덕분에,
중요한 로직을 변경하고 새로운 기능을 추가하여 업데이트 공유드립니다.

제보.지적.건의.의견 주신 내용들과 제가 파악하고 계획했던 것들 중에서
우선순위가 높다고 판단한 것들을 위주로 업데이트하였습니다.


[ 다운로드 및 설치 ]

공식 카페 게시물 (Thread KOR Community) : https://cafe.naver.com/poekorea/373080
GitHub : https://github.com/DeadlyCrush/DeadlyTrade/releases/download/0.1.3.8/DeadlyTrade_2019_0911.zip
설치 : 아무곳에나 압축을 풀고 32비트 64비트 관계없이 (한글 경로는 가급적 제외) DeadlyTrade.exe를 실행
(특정 PC에서 안될 경우 64비트 : DeadlyTrade_x64.exe)


[ 주의 사항 ]

1. 자동으로 관리자 권한을 요구하지만 그렇지 않을 경우 관리자 권한으로 실행
2. 시스템 디스플레이 배율이 기본 100%가 아닐 경우 위치가 잘못 표시됨
3. 시스템 기본 폰트를 변경하였을 경우 UI가 잘못 표시됨
4. 압축을 푼 파일의 내용을 임의로 변경할 경우 오동작함

1. 메인 로직과 API 등... 프로그램 내부적인 중요 부분이 상당 부분 변경되었습니다.

2. 메인창으로 통합 : 모든 기능 버튼이 메인창에 통합되었습니다.

3. 단축키 추가 : 돋보기, 캐릭터창으로 이동 등... 단축키들이 추가되었습니다.

4. CMD 기능 추가 : 주요 명령어들을 쉽게 사용하도록 추가되었습니다. ( 야수관, 광산, 패시브, 자동응답 등... )

5. 신디케이트 정보창 변경 : 신디케이트 정보창이 가독성과 함께 한영 전환이 가능하도록 변경되었습니다.

6. 맵 오버레이 변경 : 맵 정보 오버레이가 3.8 역병리그에 맞게 변경되었습니다.

7. 플라스크 타이머 토글 버튼 변경 : 메인창에 통합되었으며 온/오프 스위치로 변경되었습니다.

8. 스킬 타이머 추가 : 플라스크 타이머와 유사한 스킬 타이머가 추가되었습니다.

9. 거래(Trade) 채널 스캔 기능 추가 : 원하는 단어와 원치않는 단어를 입력해서 채널을 스캔하는 기능이 추가되었습니다.

10. 액트 헬퍼 복원 : 최대한 변경된 정보를 반영하여 (일부는 여전히 다를 수 있습니다.) 엑트 헬퍼를 지원합니다.

11. 거래 알림창 변경 : 거래 알림창의 아이콘 위치와 크기 및 기능 등... 이 수정/보완/추가 되었습니다.

12. 거래 알림창 자동 추방 : 자신의 파티 탈퇴나 거래대상을 추방하는 기능이 수정/보완되었습니다.

13. 닌자 시세창 성능 개선 : 카드, 예언 등... 굳이 아이콘이 다르지 않아도 되는 곳에서 성능이 개선되었습니다.

14. 닌자 시세창 기능 추가 : 실시간 닌자 시세창에서 항목을 선택 후 수량을 입력해서 카오스와 엑잘을 계산할 수 있습니다.

15. 고정핀 가독성 변경 : 고정핀을 클릭하여 고정하거나 해제하였을 때 관련된 창들이 눈에 띄도록 변경되었습니다.

16. 돋보기 창 보완 : 단축키(기본 CTRL+P)가 추가되었으며, 좌표 입력시 포커스를 벗어나지 않으며 탭 키로 이동이 가능합니다.

17. 거래 알림 개인 메시지 수정 : 개인 메시지를 수정 후 변경되지 않던 버그를 수정하여 버튼별로 설정창에서 메시지를 설정할 수 있습니다.

18. 거래 메시지 추가 지원 : 파악된 몇가지의 거래 메시지를 추가 지원합니다.
(* 제가 파악하지 못해서 알림이 뜨지 않은 ggg 유저가 보내와도 안뜨는 알림이 있다면 제보 부탁드립니다. )

19. 사용자 UI에 따른 한/영 변화 : 애드온의 메시지나 UI 중 몇몇 기능들이 사용자의 UI에 따라 한글과 영어로 바뀌어서 표시됩니다.

20. 자동응답 기능 추가 및 + 기능 : 자동응답 기능은 지역을 변경하면 자동으로 꺼지게 되어 있습니다만, ON일 경우 자동응답이 유지되도록 +기능을 넣어두었습니다.

21. UI 중요 사항 1 : 플라스크 타이머가 이제 마우스 클릭을 해도 클릭되지 않고 게임 화면이 클릭됩니다.
( 타이머의 위치를 이동할 때는 메인창의 고정핀을 해제해서 이동할 수 있습니다. )

22. UI 중요 사항 2 : 새로 추가된 스킬 타이머는 반원형태이며, 역시 플라스크 타이머와 동일하게 게임 클릭을 방해하지 않습니다.

23. UI 기타 : 몬스터남은 개수를 표시하는 UI가 조금 작게 변경되었습니다.

24. 방문자 표시 기능 보완 : 자신이 위치한 지역에 플레이어가 입장할 경우 표시되는 UI를 개선하였으며, 은신처가 아닐 경우 사냥 등에 방해가 되기 때문에 은신처에서만 동작하도록 수정하였습니다.

25. 설정창 : 설정창이 각 설정별로 세분화 되었으며, 기능 버튼의 마우스 표시가 변경되었습니다.

26. 오류창 : 특정 상황에서 오류가 날 경우 게임 진행에 방해가 되지 않도록 조치하엿습니다.
(* 만약, 게임 진행에 방해가 되도록 메시지가 나타난다면 해당 메시지를 제보해주시면 감사하겠습니다. )

27. 긴급 탈출! : 캐릭터 선택창으로 바로 나가는 단축키가 추가되었습니다. (기본 : CTRL+SPACE = CMD /exit )

28. 방해 금지 : 메인창에서 /dnd 방해금지 명령어를 스위치를 통해 즉시 ON/OFF 할 수 있습니다.

⁛ Reddit Written in English
Introduce small Addon for Helping Trade Whisper (Especially people'Exile' who struggling by Korean Language)
https://www.reddit.com/r/pathofexile/comments/ckman2/introduce_small_addon_for_helping_trade_whisper/

⁛ 한국 커뮤니티 상세 정보를 포함한 자료글
공식 카페 게시물 (Thread KOR Community) : https://cafe.naver.com/poekorea/373080

( OLD : Deadly Trade Beta 1.0 거래 도움 및 유용한 기능들 ( 해상도지원, 기능추가, 버그수정 )
https://cafe.naver.com/poekorea/293392 

⁛ Latest Release v0.1.0.1Beta
https://github.com/DeadlyCrush/DeadlyTrade/releases/tag/v0.1.0.1Beta )


⁛ a few screenshot

![DeadlyTradeBeta0101Ver (18)](https://user-images.githubusercontent.com/11026168/62420508-6d03e200-b6ce-11e9-981c-3ac98b092a55.JPG)

![DeadlyTradeBeta0101Ver_(20)](https://user-images.githubusercontent.com/11026168/62420498-3b8b1680-b6ce-11e9-915c-f7daf2a8c698.jpg)

![DeadlyTradeBeta0101Ver (44)](https://user-images.githubusercontent.com/11026168/62420511-78efa400-b6ce-11e9-813d-17afe328a00f.JPG)

![DeadlyTradeBeta0101Ver (54)](https://user-images.githubusercontent.com/11026168/62420514-7d1bc180-b6ce-11e9-9b4a-66eb47c69dda.JPG)

![DeadlyCrush_2019_0725_006](https://user-images.githubusercontent.com/11026168/62420543-c4a24d80-b6ce-11e9-903e-f8a880d0a077.png)

![Remaining](https://user-images.githubusercontent.com/11026168/62420518-8442cf80-b6ce-11e9-986f-70091140f421.png)

![DeadlyTradeBeta0101Ver (83)](https://user-images.githubusercontent.com/11026168/62420521-8a38b080-b6ce-11e9-8978-2550bc925944.JPG)

![DeadlyTradeBeta0101Ver (96)](https://user-images.githubusercontent.com/11026168/62420526-93298200-b6ce-11e9-81bf-6680adeaa018.JPG)

![DeadlyTradeBeta0101Ver_(78)](https://user-images.githubusercontent.com/11026168/62420551-f5828280-b6ce-11e9-8ab5-bf793a2c7ee9.jpg)

![DeadlyTradeBeta0101Ver (109)](https://user-images.githubusercontent.com/11026168/62420532-9b81bd00-b6ce-11e9-8a40-a090c4e81b8b.JPG)

![DeadlyTradeBeta0101Ver (115)](https://user-images.githubusercontent.com/11026168/62420533-9e7cad80-b6ce-11e9-96fb-863901dca3f8.JPG)


⁛ Latest Release v0.1.0.1Beta
https://github.com/DeadlyCrush/DeadlyTrade/releases/tag/v0.1.0.1Beta


⁛ 08.04 >

Work in progress...

A. Separating Addon's UI Text English and Korean ( Current version is Mixed UI )

B. Bug Fix, Reflect on User's Opinion&Request by priority.

[ CONTACT ]

Discord - https://discord.gg/ryjUA7r

Github - https://github.com/DeadlyCrush

Youtube - https://www.youtube.com/channel/UCRG8...

Twitch - https://www.twitch.tv/deadlycrush

Reddit - u/DeadlyCrush

https://www.reddit.com/r/pathofexile/comments/ckman2/introduce_small_addon_for_helping_trade_whisper/

Facebook - https://www.facebook.com/Deadly-Trade...

Path of Exile 한국 커뮤니티 : https://cafe.naver.com/poekorea

KAKAO Talk - https://open.kakao.com/o/gylOSztb 패스오브엑자일 DeadlyCrush

Homepage - http://deadlycrush.online/ ( Under Construction )

Twitter - twitter @deadly_crush







