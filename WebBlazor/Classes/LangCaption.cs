namespace WebBlazor.Classes
{
	public class LangCaption
	{
		public LangCaption()
		{

		}
		public LangCaption(string _lang)
		{
			switch (_lang)
			{
				case "en":
					_LangFlag = "en";
					LangJP = "Japanese";
					LangEN = "English";

					sa_project = "Project";
					sa_project_recv = "Resume & CV";
					sa_project_sou = "Source Code";

					re_subject = "Resume";
					re_name = "Name";
					re_birth = "Birth:";
					re_age = "(Age: 43)";
					re_nation = "Nationality:";
					re_british = "United Kingdom";
					re_male = "M";
					re_female = "F";
					re_address = "Address";
					re_location = "Room 804, 5-29-5 Nishiarai, Adachi-ku, Tokyo-to<br />(東京都足立区西新井５丁目２９番５－８０４号)";
					re_mobile = "Mobile:";
					re_email = "Email:";
					re_year = "Year";
					re_month = "Month";
					re_quali = "Qualification";
					re_quali_entry = "entry";
					re_quali_grad = "graduated";
					re_quali_with = "withdrawal";
					re_quali_obta = "obtained";
					re_work = "Work History";
					re_work_join = "joined";
					re_work_leave = "resigned";
					re_cert = "Certification";
					re_note = "Note";
					re_note_mess = "Visa status: Intra-company transferee (until 2028-04-14)<br /><br />" +
						"I am still learning Japanese, so I am not yet able to communicate directly in spoken Japanese. However, I can communicate in written Japanese.";
					re_apply = "Reasons for applying, special skills, favorite etc.";
					re_apply_mess = "I have been living in Japan for 4 years. During this time, I have continuously worked to improve my IT skills:<br />" +
						"Languages: C#, VB.NET, Swift<br />" +
						"Frameworks: .NET, ASP.NET Core, Blazor, WinForms, WPF, Entity Framework Core<br />" +
						"Databases: Microsoft SQL Server<br />" +
						"SDK: Visual Studio, Git, GitHub<br />" +
						"Cloud: Microsoft Azure, Google Cloud Platform<br /><br />" +
						"Now I am solely responsible for supporting my company’s IT requirements, which has given me a great valuable experience. I look forward to applying my experience in the IT industry and working collaboratively with an IT team in Japan.";
					re_remark = "Remarks";
					re_remark_mess = "Since my current visa status is \"Intra-company Transferee\", I may need to change my visa if I receive an offer.";

					cv_subject = "Curriculum Vitae";
					cv_recent = "Recently Job Summary";
					cv_recent_mess = "After joining 株式会社みかん箱 Mikanbako, I took solely responsible for developing both the company’s internal systems and external websites, covering every stage from requirements definition, system design, programming and testing.<br />" +
						"In 2026, I have completely upgraded the internal system’s framework and coding, improved the system's response speed and making modularization for easier applying ad hoc patch.";
					cv_tech = "Technical Skills";
					cv_tech_lang = "Programming Languages";
					cv_tech_frame = "Frameworks";
					cv_tech_db = "Databases";
					cv_tech_cloud = "Cloud Platforms";
					cv_tech_other = "Other Skills";

					cv_job = "Job Experience";
					cv_job_now = "now";
					cv_job_locjp = "Location: Tokyo, Japan";
					cv_job_lochk = "Location: Hong Kong";
					cv_job_buslog = "Business: International Logistics";
					cv_job_busprop = "Business: Real Estate Property Agency";
					cv_job_mencount = "Employees count: ";
					cv_job_fullemp = "Fulltime employment";
					cv_job_poseng = "Position: Engineer";
					cv_job_posprog = "Position: Programmer";
					cv_job_poscord = "Position: I.T. Co-Ordinator";
					cv_job_inover = "Overview";
					cv_job_inhand = "Responsibility";
					cv_job_inwork = "Work Scope";
					cv_job_ingoal = "Achievement";
					cv_job_01sys = "System infrastructure";
					cv_job_01a = "Setup a company servers to host databases and web application files";
					cv_job_01b = "Management, configuration, and security maintenance";
					cv_job_01c = "Register Microsoft Azure to activate cloud services";
					cv_job_01d = "Managing virtual machine as the company’s cloud server";
					cv_job_01e = "Managing operating system updates on virtual machine";
					cv_job_01f = "Managing database updates on virtual machine";
					cv_job_01g = "Managing virtual machine ports to prevent unauthorized access";
					cv_job_01h = "Successfully migrated from the old web hosting service to cloud based server";
					cv_job_01i = "Database now stores over 600,000 records";
					cv_job_01j = "Server downtime has remained under 10 minutes over the past 5 years";
					cv_job_02sys = "Project: Internal System";
					cv_job_02a = "Build and maintain an internal CMS website for the company, with continuous improvements and new feature development based on business requirements";
					cv_job_02b = "Requirement definition, system design, programming, testing";
					cv_job_02c = "Design website workflow, UI and coding";
					cv_job_02d = "Managing client records";
					cv_job_02e = "Managing clients’ shipment records";
					cv_job_02f = "Managing clients’ bank transfer records";
					cv_job_02g = "Managing warehouse inbound/outbound stock records";
					cv_job_02h = "Managing clients’ shipment request records";
					cv_job_02i = "Managing clients’ enquiry records";
					cv_job_02j = "Integrated external courier company’s API to enable automated shipment request";
					cv_job_02k = "Importing external courier company data";
					cv_job_02l = "The system has been in operation for over 10 years";
					cv_job_02m = "Successfully developed and deployed the 5th major version which has upgraded framework and coding, improved response speed and making modularization";
					cv_job_03sys = "Project: Client Shipment Request";
					cv_job_03a = "Develop a membership shipment management website that allows clients to submit shipment requests and track their delivery progress";
					cv_job_03b = "Requirement definition, system design, programming, testing";
					cv_job_03c = "Design website workflow, UI and coding";
					cv_job_03d = "Managing shipment request records";
					cv_job_03e = "Ensuring consistency between internal system and the membership shipment management website";
					cv_job_03f = "Clients have submitted over 10,000 shipment requests through the website";
					cv_job_04sys = "Project: Enquiry form";
					cv_job_04a = "Develop a client enquiry website to unify all enquiry entry points across the company’s various websites";
					cv_job_04b = "Requirement definition, system design, programming, testing";
					cv_job_04c = "Design website workflow, UI and coding";
					cv_job_04d = "Managing enquiry records";
					cv_job_04e = "Configuring automated email notifications to clients for submitted enquiry";
					cv_job_04f = "Successfully migrated multiple legacy enquiry pages into a single unified enquiry website";
					cv_job_04g = "Clients have submitted over 15,000 enquiries through the new enquriy form";
					cv_job_05sys = "Email and File System";
					cv_job_05a = "Provide email services and a cloud-based file system for company employees, including configuring automatic forwarding for designated email accounts";
					cv_job_05b = "Management and configuration";
					cv_job_05c = "Register Google Workspace to activate services";
					cv_job_05d = "Managing email logins and passwords";
					cv_job_05e = "Managing email forwarding rules";
					cv_job_05f = "Successfully migrated from the old email system to Gmail";
					cv_job_05g = "Improved file sharing efficiency using Google Drive";
					cv_job_05h = "Enhanced team collaboration efficiency using Google Docs and Google Sheets";
					cv_job_06 = "This is an overseas branch of \"株式会社みかん箱 Mikanbako\" established in Hong Kong.<br />" +
						"Due to Japan COVID related border restrictions, I was unable to obtain a visa to enter Japan. As a result, I first joined the Hong Kong branch.<br />" +
						"The job responsibilities are exactly the same as the position at Mikanbako.";
					cv_job_07sys = "Accounting System";
					cv_job_07a = "Maintain the exist accounting system and add/remove features based on user requirements";
					cv_job_07b = "Requirement definition, programming, testing";
					cv_job_07c = "Ensuring the supporting of the legacy framework of accounting system on new PCs";
					cv_job_07d = "Rapid development is necessary since user‑driven requirement changes frequently";
					cv_job_08sys = "Human Resources System";
					cv_job_08a = "Maintain the exist HR system, enhance the system, and add/remove features based on user requirements";
					cv_job_08b = "Requirement definition, system design, programming, testing and assigning tasks to 2 colleagues";
					cv_job_08c = "Due to privacy requirements, all data must be encrypted, so development work requires step‑by‑step confirmation with users";
					cv_job_08d = "Collaborating with 2 colleagues to improve the system";
					cv_job_08e = "Performing frequent testing of embedded external components during framework upgrades";
					cv_job_08f = "Resolving issues caused by non object‑oriented design and hard‑coded implementations";
					cv_job_08g = "Successfully upgraded the system from the old framework to the latest version while maintaining system performance";
					cv_job_08h = "Successfully converted and modularized most SQL Views into object‑oriented structures, improving long term maintainability";
					cv_job_09sys = "Property Information System";
					cv_job_09a = "Maintain the exist property system and adding new report formats based on user requirements";
					cv_job_09b = "Requirement definition, report design, programming, testing";
					cv_job_09c = "Coding SQL Stored Procedures to process and output data";
					cv_job_09d = "Designing reports using \"Crystal Reports\" according to user provided layouts";
					cv_job_09e = "Embedding the reports into the designated locations within the system";
					cv_abi = "Programming Ability";
					cv_abi_lang = "Language";
					cv_abi_frame = "Framework";
					cv_abi_rate = "Ability";
					cv_adv = "Advanced Qualification";
					cv_adv_obta = "obtained";


					cv_pr = "Self Promotion";
					cv_pr_mess = "Now I am solely responsible for all IT systems within the company, so I take a conservative and risk‑aware approach when handling system related matters:<br />" +
						"- Using mature and proven technologies<br />" +
						"- Carefully selecting third‑party components<br />" +
						"- Keep improve server and website security<br /><br />" +
						"In my spare time, I enjoy collecting technical information related to my workfor example, watching Microsoft Build sessions to expand my technical knowledge and test some new technologies on my personal server.<br /><br />" +
						"My recent exploration involves deploying websites using AI. AI can significantly improve coding efficiency, but the final product still requires human review and refine. I believe that \"Human‑AI collaboration\" will become a major trend in the future.<br /><br />" +
						"I am studying Japanese and BSc(Hons) Computing Degree, and I look forward a long term career in Japan.<br /><br />" +
						"I understand that Japanese communication is very important, and this is a significant weakness for me. I will work hard to overcome it, and I will never disappoint those who give me an opportunity in the future.";
					break;

				default:
					break;
			}
		}
		
		public string _LangFlag { get; set; } = "jp";
		public string LangJP { get; set; } = "日本語";
		public string LangEN { get; set; } = "英語";

		public string re_subject { get; set; } = "履歴書";
		public string re_name { get; set; } = "氏名";
		public string re_birth { get; set; } = "生日";
		public string re_age { get; set; } = "(満43歳)";
		public string re_nation { get; set; } = "国籍";
		public string re_british { get; set; } = "英国";
		public string re_male { get; set; } = "男";
		public string re_female { get; set; } = "女";
		public string re_address { get; set; } = "現住所";
		public string re_location { get; set; } = "東京都足立区西新井５丁目２９番５－８０４号";
		public string re_mobile { get; set; } = "電話";
		public string re_email { get; set; } = "メールアドレス";
		public string re_year { get; set; } = "年";
		public string re_month { get; set; } = "月";
		public string re_quali { get; set; } = "学歴";
		public string re_quali_entry { get; set; } = "入学";
		public string re_quali_grad { get; set; } = "卒業";
		public string re_quali_with { get; set; } = "退学";
		public string re_quali_obta { get; set; } = "取得";
		public string re_work { get; set; } = "職歴";
		public string re_work_join { get; set; } = "入社";
		public string re_work_leave { get; set; } = "退社";
		public string re_cert { get; set; } = "免許・資格";
		public string re_note { get; set; } = "その他特記すべき事項";
		public string re_note_mess { get; set; } = "在留資格：企業內転勤 (2028年4月14日まで）<br /><br />" +
			"私はまだ日本語を勉強しているため、現時点では日本語で直接会話することが難しいですが、書面での日本語によるコミュニケーションは可能です。";
		public string re_apply { get; set; } = "志望の動機、特技、好きな学科、アピールポイントなど";
		public string re_apply_mess { get; set; } = "日本に住んでから4年になります。この間、私は継続的にITスキルの向上に取り組んできました。<br />" +
			"言語：C#, VB.NET, Swift<br />" +
			"フレームワーク：.NET, ASP.NET Core, Blazor, WinForms, WPF, Entity Framework Core<br />" +
			"DB：Microsoft SQL Server<br />" +
			"SDK：Visual Studio, Git, GitHub<br />" +
			"クラウド：Microsoft Azure, Google Cloud Platform<br /><br />" +
			"現在、私は会社のIT要件を一人で支援しており、その経験は非常に貴重なものとなっています。これまでのIT業界での経験を活かし、日本のITチームと協力して働けることを楽しみにしています。";
		public string re_remark { get; set; } = "本人希望記入欄";
		public string re_remark_mess { get; set; } = "現在の在留資格は「企業内転勤」のため、もし内定をいただいた場合は、在留資格の変更が必要になる可能性があります。";
		public string sa_project { get; set; } = "プロジェクト";
		public string sa_project_recv { get; set; } = "履歴書 & 職務経歴書";
		public string sa_project_sou { get; set; } = "ソースコード";

		public string cv_subject { get; set; } = "職務経歴書";
		public string cv_recent { get; set; } = "職務要約";
		public string cv_recent_mess { get; set; } = "株式会社みかん箱（Mikanbako）に入社してから、私は社内システムと外部向けウェブサイトの開発を単独で担当し、要件定義、システム設計、プログラミング、テストまで、すべての工程を一貫して行ってきました。<br />" +
			"2026年には、社内システムのフレームワークとコードを全面的にアップグレードし、システムの応答速度を向上させるとともに、アドホックなパッチを容易に適用できるようモジュール化を進めました。";
		public string cv_tech { get; set; } = "技術スキル";
		public string cv_tech_lang { get; set; } = "言語";
		public string cv_tech_frame { get; set; } = "フレームワーク";
		public string cv_tech_db { get; set; } = "DB";
		public string cv_tech_cloud { get; set; } = "クラウド";
		public string cv_tech_other { get; set; } = "その他";

		public string cv_job { get; set; } = "職務経歴";
		public string cv_job_now { get; set; } = "現在";
		public string cv_job_locjp { get; set; } = "所在地：日本・東京";
		public string cv_job_lochk { get; set; } = "所在地：香港";
		public string cv_job_buslog { get; set; } = "事業内容：国際物流";
		public string cv_job_busprop { get; set; } = "事業内容：不動産仲介";
		public string cv_job_mencount { get; set; } = "従業員数：";
		public string cv_job_fullemp { get; set; } = "正社員";
		public string cv_job_poseng { get; set; } = "職種：エンジニア";
		public string cv_job_posprog { get; set; } = "職種：プログラマー";
		public string cv_job_poscord { get; set; } = "職種：ITコーディネーター";
		public string cv_job_inover { get; set; } = "概要";
		public string cv_job_inhand { get; set; } = "担当フェーズ";
		public string cv_job_inwork { get; set; } = "業務内容";
		public string cv_job_ingoal { get; set; } = "実績・取り組み";
		public string cv_job_01sys { get; set; } = "システムインフラストラクチャ";
		public string cv_job_01a { get; set; } = "データベースおよび Web アプリケーションファイルをホストするための社内サーバーを構築";
		public string cv_job_01b { get; set; } = "管理、構成、セキュリティ保守";
		public string cv_job_01c { get; set; } = "Microsoft Azure を登録し、クラウドサービスを有効化";
		public string cv_job_01d { get; set; } = "仮想マシンを会社のクラウドサーバーとして管理";
		public string cv_job_01e { get; set; } = "仮想マシンの OS アップデートを管理";
		public string cv_job_01f { get; set; } = "仮想マシンのデータベースアップデートを管理";
		public string cv_job_01g { get; set; } = "不正アクセスを防ぐため、仮想マシンのポートを管理";
		public string cv_job_01h { get; set; } = "旧来のウェブホスティングサービスからクラウドベースのサーバーへの移行に成功";
		public string cv_job_01i { get; set; } = "データベースは現在 60 万件以上のレコードを保存";
		public string cv_job_01j { get; set; } = "過去 5 年間のサーバーダウンタイムは 10 分未満を維持";
		public string cv_job_02sys { get; set; } = "プロジェクト：社内システム";
		public string cv_job_02a { get; set; } = "社内向け CMS サイトを構築・維持し、業務要件に基づいて継続的な改善および新機能開発を実施";
		public string cv_job_02b { get; set; } = "要件定義、システム設計、プログラミング、テスト";
		public string cv_job_02c { get; set; } = "Web サイトのワークフロー、UI、コーディングの設計";
		public string cv_job_02d { get; set; } = "顧客情報の管理";
		public string cv_job_02e { get; set; } = "顧客の出荷記録の管理";
		public string cv_job_02f { get; set; } = "顧客の銀行振込記録の管理";
		public string cv_job_02g { get; set; } = "倉庫の入出庫在庫記録の管理";
		public string cv_job_02h { get; set; } = "顧客の出荷依頼記録の管理";
		public string cv_job_02i { get; set; } = "顧客の問い合わせ記録の管理";
		public string cv_job_02j { get; set; } = "外部物流会社の API を統合し、出荷依頼の自動化を実現";
		public string cv_job_02k { get; set; } = "外部物流会社データのインポート";
		public string cv_job_02l { get; set; } = "システムは 10 年以上にわたり稼働";
		public string cv_job_02m { get; set; } = "フレームワークとコードを刷新し、応答速度を改善し、モジュール化を進めた第 5 世代の大型バージョンを開発・導入";
		public string cv_job_03sys { get; set; } = "プロジェクト：顧客向け出荷依頼システム";
		public string cv_job_03a { get; set; } = "顧客が出荷依頼を提出し、配送進捗を追跡できる会員制の出荷管理サイトを開発";
		public string cv_job_03b { get; set; } = "要件定義、システム設計、プログラミング、テスト";
		public string cv_job_03c { get; set; } = "Web サイトのワークフロー、UI、コーディングの設計";
		public string cv_job_03d { get; set; } = "出荷依頼記録の管理";
		public string cv_job_03e { get; set; } = "社内システムと会員制出荷管理サイトの記録整合性の維持";
		public string cv_job_03f { get; set; } = "顧客による出荷依頼は累計 10,000 件を超える";
		public string cv_job_04sys { get; set; } = "プロジェクト：問い合わせフォーム";
		public string cv_job_04a { get; set; } = "会社内の複数のウェブサイトに分散していた問い合わせ窓口を統一するため、顧客向け問い合わせサイトを開発";
		public string cv_job_04b { get; set; } = "要件定義、システム設計、プログラミング、テスト";
		public string cv_job_04c { get; set; } = "Web サイトのワークフロー、UI、コーディングの設計";
		public string cv_job_04d { get; set; } = "問い合わせ記録の管理";
		public string cv_job_04e { get; set; } = "問い合わせ送信後に顧客へ自動メール通知を行う設定";
		public string cv_job_04f { get; set; } = "複数の旧式問い合わせページを統合し、単一の問い合わせサイトへ移行することに成功";
		public string cv_job_04g { get; set; } = "新しい問い合わせフォームを通じて、顧客からの問い合わせは累計 15,000 件を超える";
		public string cv_job_05sys { get; set; } = "メールおよびファイルシステム";
		public string cv_job_05a { get; set; } = "指定されたメールアカウントの自動転送設定を含め、社員向けにメールサービスとクラウドベースのファイルシステムを提供";
		public string cv_job_05b { get; set; } = "管理および設定";
		public string cv_job_05c { get; set; } = "Google Workspace を登録し、サービスを有効化";
		public string cv_job_05d { get; set; } = "メールアカウントのログイン情報およびパスワードを管理";
		public string cv_job_05e { get; set; } = "メール転送ルールを管理";
		public string cv_job_05f { get; set; } = "旧のメールシステムから Gmail への移行に成功";
		public string cv_job_05g { get; set; } = "Google Drive によりファイル共有効率を向上";
		public string cv_job_05h { get; set; } = "Google Docs / Google Sheets によりチームの協働効率を改善";
		public string cv_job_06 { get; set; } = "これは、香港に設立された「株式会社みかん箱（Mikanbako）」の海外支店です。<br />" +
			"日本の新型コロナウイルス関連の入国制限により、私は日本への入国ビザを取得できず、その結果、まず香港支店に入社しました。<br />" +
			"業務内容は、みかん箱本社での職務と完全に同一です。";
		public string cv_job_07sys { get; set; } = "会計システム";
		public string cv_job_07a { get; set; } = "既存の会計システムを維持し、利用者の要件に応じて機能の追加・削除を行う";
		public string cv_job_07b { get; set; } = "要件定義、プログラミング、テスト";
		public string cv_job_07c { get; set; } = "会計システムのレガシーフレームワークが新しい PC でも動作するように対応";
		public string cv_job_07d { get; set; } = "利用者からの要件変更が頻繁なため、迅速な開発が必要";
		public string cv_job_08sys { get; set; } = "人事システム";
		public string cv_job_08a { get; set; } = "既存の人事システムを維持しつつ、システムの改善を行い、利用者の要件に応じて機能の追加・削除を実施";
		public string cv_job_08b { get; set; } = "要件定義、システム設計、プログラミング、テスト、2名の同僚へのタスク割り当て";
		public string cv_job_08c { get; set; } = "個人情報保護のため、すべてのデータを暗号化する必要があり、開発作業では利用者との逐次確認が必須";
		public string cv_job_08d { get; set; } = "2名の同僚と協力しながらシステム改善を推進";
		public string cv_job_08e { get; set; } = "フレームワーク更新時に、組み込まれている外部コンポーネントの頻繁なテストを実施";
		public string cv_job_08f { get; set; } = "非オブジェクト指向設計やハードコードによる問題の解消";
		public string cv_job_08g { get; set; } = "旧フレームワークから最新バージョンへのアップグレードに成功し、システム性能を維持";
		public string cv_job_08h { get; set; } = "多くの SQL View をオブジェクト指向構造へ変換・モジュール化し、長期的な保守性を向上";
		public string cv_job_09sys { get; set; } = "物件情報システム";
		public string cv_job_09a { get; set; } = "既存の物件情報システムを維持し、利用者の要件に応じて新しい帳票形式を追加";
		public string cv_job_09b { get; set; } = "要件定義、帳票設計、プログラミング、テスト";
		public string cv_job_09c { get; set; } = "データを処理・出力するための SQL ストアドプロシージャのコーディング";
		public string cv_job_09d { get; set; } = "利用者が提供したレイアウトに基づき、Crystal Reports を使用して帳票を設計";
		public string cv_job_09e { get; set; } = "帳票をシステム内の指定された位置へ組み込み";
		public string cv_abi { get; set; } = "技術力";
		public string cv_abi_lang { get; set; } = "言語";
		public string cv_abi_frame { get; set; } = "フレームワーク";
		public string cv_abi_rate { get; set; } = "能力";
		public string cv_adv { get; set; } = "上級資格";
		public string cv_adv_obta { get; set; } = "取得";

		public string cv_pr { get; set; } = "自己PR";
		public string cv_pr_mess { get; set; } = "現在、私は会社のすべてのITシステムを単独で担当しており、システム関連の業務においては慎重かつリスクを意識したアプローチを取っています：<br />" +
			"- 成熟した実績のある技術を使用すること<br />" +
			"- 第三者コンポーネントを慎重に選定すること<br />" +
			"- サーバーおよびウェブサイトのセキュリティを継続的に強化すること<br /><br />" +
			"また、業務に関連する技術情報を収集することが好きで、Microsoft Build のセッションを視聴して知識を深めたり、個人サーバーで新しい技術を試したりしています。<br /><br />" +
			"最近では、AI を活用したウェブサイトの構築にも取り組んでいます。AI はコーディング効率を大幅に向上させますが、最終的な成果物には人による確認と調整が不可欠です。「人とAIの協働」は今後大きな潮流になると考えています。<br /><br />" +
			"現在、日本語とコンピューティング学士課程（BSc(Hons) Computing Degree）を学んでおり、日本で長期的なキャリアを築くことを目指しています。<br /><br />" +
			"日本語でのコミュニケーションが非常に重要であることを理解しています。これは自分にとって大きな弱点ですが、努力を重ねて必ず克服します。将来、私に機会を与えてくださる方を決して失望させません。";
	}
}