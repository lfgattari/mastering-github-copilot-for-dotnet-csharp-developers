<header>

# GitHub Codespaces 소개

GitHub Codespaces의 세계에 오신 것을 환영합니다. 클라우드 기반 코딩의 관문인 Codespaces는 즉각적이고 클라우드에서 호스팅되는 개발 환경을 통해 코딩 방식을 새롭게 정의합니다. GitHub Codespaces는 필수 언어, 도구, 유틸리티가 완비된 컨테이너를 제공하며, 원활하고 통합된 코딩 경험을 제공합니다.

이 학습 여정을 통해 Codespaces의 전체 라이프사이클을 탐구하고, 자신의 취향과 요구에 맞게 환경을 커스터마이징하는 방법을 배우게 될 것입니다. 학습을 강화하기 위해, 이 모듈은 GitHub Codespaces 환경에서 직접 실습하며 기술을 적용할 수 있는 실습 과제로 마무리됩니다.

완벽하게 구성된 개발 환경이 준비되어 있으며, 인터넷이 연결된 어떤 컴퓨터에서도 접근할 수 있다고 상상해보세요. GitHub Codespaces는 협업적이고 유연한 코딩의 새로운 시대를 열어줍니다. 함께 클라우드 기반 개발의 모든 잠재력을 열어봅시다!!

</header>


- **대상**: 개발자, DevOps 엔지니어, 엔지니어링 매니저, 제품 관리자.
- **학습 내용**: Codespace 생성 방법, Codespace에서 코드 푸시하기, 사용자 정의 이미지 선택하기, Codespace 커스터마이징하기.
- **구축할 것**: devcontainer.json 파일, 커스터마이징 및 개인화가 포함된 Codespace.
- **선행 조건**: 다음을 알고 있어야 합니다:
  - Visual Studio Code 사용법, [Visual Studio Code 문서](https://code.visualstudio.com/docs).
  - GitHub 사용 이해 또는 이전 모듈 [GitHub 소개](https://github.com/microsoft/mastering-github-copilot-for-dotnet-csharp-developers/blob/main/01-Introduction-to-GitHub/README.md) 완료.
- **소요 시간**: 이 과정은 한 시간 이내에 완료할 수 있습니다.

이 모듈을 완료하면 다음을 수행할 수 있습니다:

1. GitHub Codespaces를 설명할 수 있습니다.
2. GitHub Codespaces 라이프사이클을 설명하고 각 단계를 수행하는 방법을 이해합니다.
3. GitHub Codespaces에서 개인화할 수 있는 다양한 커스터마이징을 정의합니다.


## 선행 학습 자료: 

- [GitHub Codespaces로 코딩하기](https://learn.microsoft.com/training/modules/code-with-github-codespaces/)
- GitHub Codespaces란? (아래 동영상 재생 목록)
- [![Codespaces란?](https://img.youtube.com/vi/ozuDPmcC1io/0.jpg)](https://www.youtube.com/watch?v=ozuDPmcC1io&list=PLmsFUfdnGr3wTl-NCblzcrEv2lFSX975-)



### 이 과정을 시작하는 방법

<!-- 과정 시작을 위해 JavaScript에서 실행:
'https://github.com/new?' + new URLSearchParams({
  template_owner: 'skills',
  template_name: 'code-with-codespaces',
  owner: '@me',
  name: 'skills-code-with-codespaces',
  description: 'My clone repository',
  visibility: 'public',
}).toString()
-->

[![start-course](https://user-images.githubusercontent.com/1221423/235727646-4a590299-ffe5-480d-8cd5-8194ea184546.svg)](https://github.com/new?template_owner=skills&template_name=code-with-codespaces&owner=%40me&name=skills-code-with-codespaces&description=My+clone+repository&visibility=public)

1. **Start course**를 오른쪽 클릭하고 새 탭에서 링크를 엽니다.
2. 새 탭에서 대부분의 프롬프트가 자동으로 채워집니다.
   - 소유자(owner)로 개인 계정 또는 저장소를 호스팅할 조직을 선택합니다.
   - 개인 저장소는 [Actions 분 사용](https://docs.github.com/billing/managing-billing-for-github-actions/about-billing-for-github-actions)이 발생하므로, 공개 저장소를 만드는 것을 권장합니다.
   - 아래로 스크롤하여 양식 하단의 **Create repository** 버튼을 클릭합니다.
3. 새 저장소가 생성된 후 약 20초 정도 기다렸다가 페이지를 새로고침하세요. 새 저장소의 README에 있는 단계별 지침을 따르세요.

<footer>

---

도움이 필요하세요? [토론 게시판에 글 남기기](https://github.com/orgs/skills/discussions/categories/introduction-to-github) • [GitHub 상태 페이지 확인하기](https://www.githubstatus.com/)

**면책 조항**:  
이 문서는 기계 기반 AI 번역 서비스를 사용하여 번역되었습니다. 정확성을 위해 노력하고 있으나, 자동 번역에는 오류나 부정확성이 포함될 수 있음을 유의하시기 바랍니다. 원본 문서의 해당 모국어 버전이 권위 있는 자료로 간주되어야 합니다. 중요한 정보에 대해서는 전문 인간 번역을 권장드립니다. 이 번역 사용으로 인해 발생하는 오해나 잘못된 해석에 대해 당사는 책임을 지지 않습니다.