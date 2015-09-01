﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace EldYoungAndroidApp
{
	[Activity (Theme = "@style/MyCustomTheme")]			
	public class ServiceAgreeActivity : Activity
	{
		private string strServiceAgree = "\n服务条款\n\n生效日期：2015 年 4 月 29 日\n\n欢迎来到颐阳智能！我们邀请您访问我们的网站、使用颐阳智能服务并在Evernote Market购物，但是请注意，我们对您的邀请取决于您审阅并同意本服务条款。此文档详细介绍了与服务（定义如下）之提供及Evernote Market之运营有关的您我双方的权利，因此敬请仔细阅读。\n服务条款是什么？\n\n本服务条款构成我们之间的合同。本条款包括在本文档和颐阳智能隐私政策、商业条款和用户指南中的规定，以及其他可能不时向您提供并且您接受的与特定服务产品相关的条款或条件（我们将这些统称为“服务条款”或“条款”）。如果您不同意本条款，则无权访问或使用我们的服务，亦无权从Evernote Market购买任何产品或服务。一经注册或以其他方式使用我们的服务或者在Evernote Market购买任何产品或服务，您将被视为确认接受本条款并同意成为具有约束力的本合同的一方。通过使用本服务及在Evernote Market购买任何产品，您确认、接受并同意隐私政策的所有条款，包括但不限于，依据隐私政策使用和处理您的账户信息（定义如下）和内容（定义如下）。\n颐阳智能服务是什么？\n\n颐阳智能服务包括颐阳智能软件（定义如下）以及由颐阳智能托管或提供的其他产品、服务和网站，通过它们，您可以在多台计算机设备和系统上做许多精彩的事（统称为“服务”）。为能够使用本服务，您同意遵守本条款。\n如果这是合同，合同各方是谁？\n\n您是本合同的一方。本合同的另一方是北京颐阳智能科技有限公司，一家总部设在中国北京的有限责任公司，在本服务条款中称为 “颐阳智能”及有时称为“我们”。敬请阅读我们的商业条款，了解有关从Evernote Market购买产品的附加合同条款。\n\n在有些情况下，您可能从授权的经销商处购买Evernote Market产品或颐阳智能企业版。请查看我们的商业条款中有关此类购买情况的附加合同条款。\n这是我与颐阳智能之间的唯一合同吗？\n\n这取决于您如何使用颐阳智能服务、我们的应用软件以及Evernote Market。如果您在计算设备上安装任何颐阳智能软件，您可能会被要求就一份终端用户许可协议作出同意。如果您使用相关的颐阳智能产品或服务（如颐阳智能企业版）、从Evernote Market购买产品或参加我们的用户论坛，您可能还需要与我们另行签订一份独立协议（通常单击“接受”或“同意”即可）。我们将每份这样的协议称为“独立协议”。如果出现这种情况，独立协议之条款和本条款之间存在冲突的情况下，应以独立协议为准，但以该冲突和与该独立协议特定事宜相关为限。\n这些服务条款会变更吗？\n\n由于我们的服务和适用于您我双方的法律会发生变更，本条款几乎必然会予以修订。如果我们作出变更，我们将竭尽所能提前通知您，但是在某些情况下（例如当需要进行变更以满足适用法律要求时），对本条款的更新可能需要立即生效。我们将在我们的网站公布变更，也可能选择使用您提供给我们的电子邮件地址向您发送变更通知。我们也将尽力解释变更原因。\n\n如果我们更新这些条款，您有权决定接受更新的条款还是停止使用我们的服务（见下文“如何关闭我的帐户”）；您在更新生效之后继续使用本服务之行为，将视为您就新条款与我方达成一致并同意受其约束。除此处所述的由我们做出的变更外，对这些条款的任何其他修订或修改均无效，除非你我双方在明确修订这些条款并且有书面签字的书面协议中另有规定。为清楚起见，出于此目的，电子邮件或其他通信将不构成有效的书面协议。\n要使用颐阳智能服务，我必须做些什么？\n\n首先，您需要创建一个颐阳智能服务帐户。您向我们提供电子邮件地址并设定密码，即可创建帐户。（某些较旧版本帐户还需要用户名。）我们会按照适用法律法规的要求在某些服务中要求您提供真实姓名和其他个人身份信息，并将在成功核验该等信息后创建您的账户。我们将上述信息称为您的“账户信息”。我们鼓励您使用独特、不易破解且不同于您在任何其他服务中使用的密码。您有责任维护您账户信息的准确性、完整性和保密性，并对您的账户下发生的所有活动（包括获得您的账户信息的其他人的活动）负责。因您提供的信息不正确或您未能确保您的账户信息的安全而造成任何损失或损害的，我们概不负责。如果您发现有人未经授权使用您的账户信息或怀疑任何人未经授权可能能够访问您的私有内容，您应立即更改密码，并通知我们的客户支持团队。\n\n第二，您需要通过网页浏览器或者在您的计算机、平板电脑和手机上安装我们的客户端软件来访问您的帐户。但是很抱歉，您需要自行获得这些设备、并为其互联网和数据计划付费。颐阳智能对于访问本服务所需的互联网及其他电信服务的可用性概不负责。\n我可以与他人共享账户吗？\n\n颐阳智能服务账户不该共享。若您与任何人共享您的账户信息，该人可能能够控制您的账户，而我们可能无法鉴别谁是真正的账户持有人。这种情况下，我们将不会就您或者与您共享账户信息的任何人的行为而向您（或他们）负责。由于您使用的可能是免费服务账户，且我们已提供多种机制允许您与他人共享账户内容，除为遗产规划之目的（见下文）外，我们强烈建议您不要与任何人共享您的账户信息。若您正寻找与他人共享内容的途径，特别是在商务、学校或其他组织环境中，我们鼓励您使用颐阳智能企业版。\n拥有账户之后，我在颐阳智能服务中享有什么权利？\n\n在适用于您的法律不禁止您接受本服务的前提下，您的账户被创建并在您接受本条款之后，我们即授予您根据本条款使用本服务的有限的、非独占性的许可，直到您自愿关闭账户或者我们根据本条款关闭您的账户为止。此外，我们向您授予使用由颐阳智能或其代表提供给您的颐阳智能软件的个人的、全球性的、免版税的、不可转让及非独占性的许可。该许可的唯一目的是便于您根据颐阳智能软件中的任何适用许可条款和本条款使用颐阳智能软件并受益于本服务，直到您的权利依据该许可和/或本条款终止。您不会获得颐阳智能或本服务中的任何其他权利或利益。\n我对颐阳智能中储存的内容享有什么权利？\n\n您保留您在本服务中或通过本服务提交、发布或显示内容之前就您的内容您已经享有的著作权及任何其他权利。但是，您必须授予颐阳智能有限的许可（如下文所述），以便我们让您可以通过本服务访问和使用您的数据。除此有限许可及您在本条款中授予的其他权利外，颐阳智能承认并同意，我们不会根据本条款获得您对任何内容享有的任何权利、所有权或利益。\n我必须授予颐阳智能什么许可？\n\n为了让颐阳智能运营本服务，我们必须从您获得处理您的内容的特定有限许可权利，这样我们在运营服务中的技术操作将不会被视为违法行为。比如，版权法可阻止我们对您的内容进行处理、维护、存储、备份和分发，除非您授予我们这些权利。因此，通过使用本服务和上传内容，您授予颐阳智能显示、执行和分发您的内容以及修改（为技术目的，例如，确保内容可在智能手机、电脑和其他设备上查看）和复制此类内容的许可，以便颐阳智能运营本服务。您还同意，颐阳智能有权根据自行判断选择拒绝接受、公布、存储、显示、发布或传输任何内容。\n\n您同意，这些权利和许可是免版税的、全球范围内可用的、不可撤销的（只要您的内容存储在我们处），并包括颐阳智能享有的以下权利：为提供此类服务之唯一目的，将此类内容提供给与颐阳智能拥有合同关系（与提供颐阳智能服务有关）的其他人，并向其转移这些权利；以及，若颐阳智能认为遵守其法律义务需要，许可第三方访问或向第三方披露您的内容。\n\n如果您选择使用与颐阳智能已集成的任何第三方服务或应用程序，您亦同意根据前款授予颐阳智能的权利和许可适用于通过此类第三方服务或应用程序提交或上传的内容。如果您选择使用的第三方服务或应用程序将访问或提取您的内容，则您授予颐阳智能权利和许可，以启用对您的内容的此类访问和提取。针对上述第三方应用程序或服务提供商的作为或不作为，颐阳智能不负有任何义务或承担任何责任。\n\n由于我们信赖您上传和分发内容的权利，您向颐阳智能声明并保证，您拥有将您的内容提交至颐阳智能、使用本服务实现任何其他用途、发布或分发您的内容以及授予颐阳智能本条款中所述的权利的完全不受约束的法律权利和权力。\n\n最后，您理解并同意，颐阳智能在执行为我们的用户提供服务所需的技术步骤中，出于符合和适应连接网络、设备、服务或媒体的技术要求的需要，可能对您的内容做出更改。\n我还必须向颐阳智能做出哪些其他保证？\n\n当您使用颐阳智能服务向电子邮件地址、通过 SMS 向电话号码或者通过尚未与颐阳智能帐户关联的社交媒体站点发送“工作群聊”消息时，颐阳智能将代表您发送此类消息，并且我们是依赖于您所做出的您与接收者有直接关系并且您尊重接收者不接收某些类型消息（例如骚扰信息、未经请求的商业信息、以及不需要的短消息）的法律权利的声明。无论何时您通过“工作群聊”向第三方发送任何类型的消息，您向颐阳智能声明并保证您是在法律范围内行事并且您已获得接收者的事先同意向他们发送此类消息。\n关于我可以用颐阳智能服务做些什么，有相关规则吗？\n\n有。您对本服务的使用必须符合这些条款。涉及到您对本服务的使用时，您同意对您自己的行为以及您的帐户下的所有行为负责。这意味着对于在您的账户中创建、传输、存储或显示的所有内容，如文本、图片、软件、视频以及您能想到的任何其他内容，无论采用何种形式或技术结构（统称为“内容”），您将作为内容创建者或将其引入本服务的人对其承担完全责任。无论内容是否使用本服务或与颐阳智能服务连接的任何第三方应用程序或服务进行保密、共享或传输，本规定均予以适用。\n\n您对服务的使用须遵守本条款和适用的法律法规。您同意使用该服务时：\n\n    请勿使用颐阳智能来备份你的硬盘或进行其它悖离颐阳智能使用功能的操作。颐阳智能的设计和开发是围绕增强效率这一主题。包括记笔记、剪藏网页、截图、项目管理、协作交流和共享文件等在内的支持现代高效协作方式的功能（即“预设用途”）。颐阳智能的设计和开发并不是为了提供云备份、文件同步或文件存储/存取服务（“不支持用途”）。不支持用途包括使用颐阳智能进行硬盘备份，存储影音文件，自动存档邮件或文件，或存储大量文件都会降低您和/或他人的颐阳智能使用体验。使用颐阳智能获得的使用质量是建立在遵循其预设用途基础之上的。\n    请勿用作不合法目的或为推广危险活动而使用我们的产品或服务；\n    请勿假扮任何人或实体（包括但不限于我们的员工），或假称或不实陈述您与我们或任何其他人或实体的关联；\n    请勿为掩饰通过服务传输的任何内容的出处，伪造页眉或假造标识符；\n    请勿上传、发布或传播您在任何法律或合同关系或信托关系项下无权传播的任何内容（如作为劳动关系的一部分或在保密协议项下知悉或披露的内幕信息、专有及保密信息）；\n    请勿上传、发布或传播任何侵犯任何方的任何专利、商标、商业秘密、版权或其他专有权利的内容；\n    请勿上传、发布或传播任何未经请求或未经授权的广告、推广材料、“垃圾邮件”、“兜售信息”、“连锁信”、“金字塔骗局”或任何其他形式的招揽；\n    请勿上传、发布或传播任何旨在中断、破坏或限制任何计算机软件、硬件或电信设备功能的，含有软件病毒或任何其他计算机编码、文件或程序的资料；\n    请勿干涉或妨碍服务或与服务有关的服务器或网络，或不遵守任何与服务有关或适用于服务的网络的要求、程序、政策或规定；\n    请勿违反中国宪法的基本原则，或违反任何适用的中国法律或任何具有法律效力的规定；\n    请勿“偷偷接近”或以其他方式骚扰另一人或公司，或未经该另一人的允许（如通过发布另一人的照片、地址、电子邮件、电话号码或任何其他联系信息等）采取侵犯他人隐私的任何行动；\n    请勿为商业目的收集或存储有关其他用户的个人资料；\n    请勿推广或提供有关非法活动的指导性信息，推广针对政府、法律实体、团体或个人的物理性伤害或损害，或推广虐待动物的行为，包括但不限于就如何装配爆炸装置或其他武器或纵火装置提供指导；\n    请勿将服务用作向另一个网站的转发手段；\n    请勿允许他人以违反本服务条款的方式使用服务；.\n    请勿未经事先批准，在服务范围内或代表我们从事商业活动，包括但不限于以下活动：\n    请勿展示旨在为您或任何其他企业或组织营利的标语；或\n    请勿展示用于向用户提供现金或现金等价物奖金以换取连接该等用户的网站之超链接的标语；\n    请勿利用手段妨碍服务范围内任何广告的充分和完全展示，包括但不限于，有效阻止或实质上损害服务范围内的广告展示的风格变更、定制或覆盖；\n    请勿为非预期、商业或不合法的目的，向其他用户索取密码或个人辨识信息；\n    请勿超出您注册的服务范围，例如：获取及使用您无权使用的特性，或在您未获授权的情形下，删除、添加或变更另一人之录入项目或其他内容；\n    请勿通过我们所提供的界面以外的任何方式（除非在独立协议中明确允许您如此行事）获取（或试图获取）任何服务，或通过任何自动化的途径（包括使用脚本、网络蜘蛛等）获取（或试图获取）任何服务，或以经合理判断可能对运营服务的系统或他人获取或使用服务造成损害的方式使用服务；及/或；\n    请勿为任何商业目的，复制、复印、出售、买卖、转售或利用任一部分服务，或对服务的使用（除非经独立协议中明确允许）；\n    请勿采取任何可能违反我们的相关商标使用要求的行动；及\n    请勿上传或展示以下内容：\n        反对中华人民共和国宪法所确定的基本原则的；\n        危害国家安全、泄露国家机密、颠覆国家权力、破坏国家统一的；\n        损害中华人民共和国荣誉和利益的；\n        煽动民族仇恨、种族歧视、破坏民族内部团结的；\n        破坏国家宗教政策，宣扬邪教和封建迷信的；\n        散布谣言、扰乱社会秩序、破坏社会稳定的；\n        含有裸露、性暴露内容或被我们视为暴露的；\n        鼓励赌博、暴力、凶杀、恐怖或煽动犯罪行为的；\n        含威胁性、辱骂性、骚扰性、诽谤性、损害名誉性、侵犯性、憎恨性或从种族、民族或其他角度令人不快的；\n        侮辱或诽谤他人、侵犯他人合法权益的；或\n        含有法律、行政法规不时禁止的任何其他内容的。\n\n如果我们发现您账户中的任何内容违反了我们的服务条款，我们保留将其删除或不向公众公布的权利。此外，您将就任何第三方因您违反上述条款而遭受的所有损害承担责任，及如颐阳智能因您的违反遭受损失，您也应当赔偿颐阳智能的该等损失。\n颐阳智能会查看我的内容吗？\n\n我们非常重视保护您对您的内容享有的隐私权，我们希望在任何时候都无需要检查任何人的内容。但是，如在我们的隐私政策中所讨论，在特定情况下，我们可能需要查看您的部分或全部内容。\n其他人会看到我的内容吗？\n\n除本条款以及我们的隐私政策所述外，除非您选择让其他人查看或访问您提交至本服务的内容，未经您的同意，其他任何人都不会看到您的内容。当然，如果您选择将您的内容的任何部分置于一个或多个共享笔记本中、将笔记发送给其他人、或者与他人共享您的账户信息，从而对其进行发布或共享，则您将允许该共享笔记本的许可用户、该笔记的收件人或账户信息的接收人访问、使用、显示、执行、分发和修改您的内容（受在颐阳智能没有参与的情况下您和这些用户可能达成的任何理解或协议的约束）。此外，颐阳智能使您能够使用与本服务和您的内容进行交互的各种第三方服务和应用程序，由于您可能通过与有关各方订立的协议，授予其访问您内容的权限，敬请查阅您提供给这些服务或应用程序的访问权限。\n颐阳智能是否享有某些与本服务相关的权利？\n\n是的。这些权利描述如下：\n内容权。\n\n您拥有您存储于颐阳智能服务的内容（符合第三方权利），同时您承认并同意，颐阳智能（和我们的许可方）拥有本服务的所有合法权利、所有权和利益，包括但不限于在颐阳智能服务器上托管并构成本服务组成部分的所有软件，以及由您或第三方部署以撷取来自于本服务外的内容的所有软件，如 Evernote Scannable、颐阳智能·悦读、颐阳智能·剪藏、颐阳智能·圈点、颐阳智能·墨笔、颐阳智能·食记或任何为了能够使用兼容计算设备访问和使用本服务而对该设备提供的任何颐阳智能软件应用程序（下称 “颐阳智能软件”）。\n知识产权。\n\n同意本条款即表示您也同意本服务和颐阳智能软件中包括所有知识产权在内的权利，例如商标、专利、工业设计和版权，除了受本条款和任何独立协议的保护之外，也受一项或多项著作权、商标权、专利权、商业秘密和其他法律、法规和条约的保护。尤其是，您同意不修改任何颐阳智能的软件、对其制作衍生作品、反编译或以其他方式尝试提取其源代码，除非您根据开源许可证得到明确许可，或者得到我们的明确书面许可，或者有其他合法许可。\n修改本服务的权利。\n\n我们保留自行决定实施新元素之权利无论是否另行通知，该新元素作为本服务和任何颐阳智能软件组成部分和/或辅助部分，包括可能会影响本服务先前经营模式或颐阳智能软件的更改。我们期望任何此类修改均将改善整体服务，但是您可能不同意我们这样做。我们亦保留下列权利：设定为您提供的存储性质或大小、传输和电子邮件信息的数量、任何索引或库信息的性质或大小，您的内容及其他信息的性质或您访问或分发您的内容和其他数据的持续能力，并有权随时施加其他限制，无论是否另行通知。例如，如果您使用颐阳智能免费帐户，您将无法享受为颐阳智能标准帐户、高级帐户或企业版用户提供的所有服务。\n\n您也承认，各种颐阳智能行为可能在有限期间内或永久地妨碍或阻止您访问您的内容，或在特定时间段内和/或以同样方式使用本服务，并且您同意颐阳智能对任何此类行为或结果造成的任何结果，包括但不限于删除任何内容或未能向您提供任何内容，概不承担任何责任或义务。您同意，对于本服务任何部分的修改、暂停或中止，我们对您或任何第三方概不承担任何责任。但是，如果您是颐阳智能标准帐户、高级帐户、颐阳智能企业版或另一付费版本的颐阳智能服务（单称“付费服务”）的订购者，并发现对此付费服务的任何此类修改或中断对您有不利影响，您可以通知我们的客户支持团队，说明修改所造成的不利影响，并且如您希望，可要求终止您的付费服务。在收到任何此类要求后，我们将会尽力及时纠正修改所造成的不利影响，并在我们认为适当时，将您的付费服务订购期延长至等同于中断时间的期间和/或退还等同于剩余未使用的付费服务订购期的那部分付费服务订购费用。\n聘请第三方的权利。\n\n颐阳智能可能不时聘请若干关联公司或其他第三方提供与本服务全部或部分相关的技术服务或其他服务，或者履行与Evernote Market运营相关的特定职能，您在此同意接受这样的第三方服务。此外，颐阳智能可能与颐阳智能标准帐户、高级帐户或颐阳智能企业版和/或Evernote Market中的服务和/或产品的的第三方经销商以及第三方支付机构合作，让您以当地的货币和支付系统完成付款。请参阅我们的隐私政策，理解任何关联公司或第三方对于您的账户信息或内容可以访问的程度，以及我们的商业条款来了解我们与任何经销商或支付处理商之间的关系。\n使用第三方软件的权利。\n\n颐阳智能可能不时将第三方提供的计算机软件作为本服务和颐阳智能软件的组成部分。上述计算机软件经相应的许可人和/或著作权持有人许可，按照各方规定的条款使用。我们在此处和特定的颐阳智能软件内提供有关此第三方软件的部分信息。就此类第三方软件，颐阳智能明确否认对您的任何担保或其他保证。\n更新我们软件的权利。\n\n对于本服务的任何修改，颐阳智能可能会不时自动在您的计算机和设备中下载软件更新，旨在改善、提高、修复和/或进一步发展本服务。颐阳智能将尽力为您提供是否安装任何更新的选项，但是，在某些情况下（例如，安全隐患），颐阳智能可能要求您在继续访问本服务前安装更新。在所有情况下，作为您使用本服务的组成部分，您同意允许颐阳智能向您提供这些更新（且您同意接收这些更新）。\n本条款适用于颐阳智能企业版用户吗？\n\n如果您正在使用的本服务为颐阳智能企业版账户的组成部分，您对本服务的使用将受本条款制约，但与颐阳智能企业版账户的独立协议的条款冲突的条款除外。创建颐阳智能企业版帐户的管理员负责向每个颐阳智能企业版帐户用户共享此独立协议的条款。如果您可以访问颐阳智能企业版账户的笔记本，请与颐阳智能企业版管理员检阅适用于您使用本服务的合同条款。\n\n如果您是颐阳智能企业版账户的用户，您应该知道颐阳智能企业版账户管理员有权限制您访问颐阳智能企业版账户笔记本中所包含的内容，也有权访问、复制、分发和以其他方式影响这些内容，以及对其实施其他规则。\n\n但是，管理员无权访问亦不会获得您的个人账户中的信息。如果您同时拥有颐阳智能个人账户及企业账户下笔记本的访问权限，您在个人账户中的任何权利均不受影响。如欲多了解您的颐阳智能个人账户与颐阳智能企业账户的关系，敬请浏览我们的隐私条款或访问知识库文章中的“其他颐阳智能企业版用户或管理员可以获取用户的私人笔记本或个人信息吗？”。\n颐阳智能如何应对著作权或其他知识产权的侵权行为？\n\n根据我们的政策，我们将对合乎适用法律法规的清晰且完整的著作权侵权指控通知做出回应，并将对适用的著作权法律做出回应。如果您认为您的作品在服务中使用或发表的方式构成著作权侵权，或您的知识产权受到其他侵犯，请根据本条款规定的程序向我们发出正式通知，并在通知中包含以下信息：\n\n    您的姓名（名称）、联系方式和地址；\n    要求删除或者断开链接的侵权作品、表演、录音录像制品的名称和网络地址；\n    构成侵权的初步证明材料；\n    在通知上签名；如通知由公司或组织提交，应加盖公司或组织的公章。\n\n敬请注意您必须对通知的内容的真实性负责。\n\n敬请注意，我们有权复制我们收到的任何法律通知并为公布或评论之目的将其寄送至第三方，且我们可以在已删除内容的原先位置或我们网站的其他区域发表您的通知。我们将在收到您的来函后48个营业小时内，对所有完整且合格的通知做出回应和/或采取行动，并保留经由电子邮件或其他方式与您沟通的权利。\n\n另一方面，我们已上传或传输内容的用户收到本条所述通知书后，有权根据适用的法律法规发出反向通知。收到反向通知后，我们可以恢复该通知涉及的材料。\n\n如需向我们发出反向通知，您必须按照下文所述要求提供书面通知。敬请注意，如果您虚假陈述任何内容或活动并未侵犯他人著作权，您将承担损害赔偿责任（包括诉讼费和律师费）。因此，如果您不确定某些材料是否对他人著作权构成侵权，我们建议您先行与专业法律顾问进行沟通。\n\n为了我们能够尽快处理您的反向通知，请向我们提供包含以下信息的正式通知：\n\n    您的姓名（名称）、联系方式和地址；\n    要求恢复的作品、表演、录音录像制品的名称和网络地址；\n    不构成侵权的初步证明材料；及\n    在反向通知上签名；如通知由公司或组织提交，应加盖公司或组织的公章。\n\n敬请注意您必须对反向通知的内容的真实性负责。\n儿童可以使用颐阳智能吗？\n\n当然可以，但是颐阳智能并不直接面向儿童用户，我们希望儿童仅在接受其父母、监护人和/或授权学校官员指导、监督并经其同意的前提下使用。此外，我们依赖家长和监护人确保未成年人仅在其理解本条款和我们的隐私政策规定中所述的其权利和责任的情况下使用本服务。\n\n如果您未满18岁，请在登记使用本服务前取得您父母或监护人的指导和同意。\n如何关闭我的账户？\n\n您可以随时以任何理由（或无理由）停用您使用我们服务的账户，甚至不必通知我们。但是，如需停用帐户，您需要采取一些特定步骤，请参考这篇知识库文章。\n\n根据本条款，颐阳智能可以经发出通知或者不另行通知限制您的帐户使用本服务、暂停对您账户的访问或关闭您的账户。颐阳智能暂停或关闭您的帐户的原因可能包括但不限于：(i) 对本条款或任何独立协议或任何适用法律法规的违约或违反（由颐阳智能合理确定）；(ii) 持续长时间不活动（由颐阳智能自主确定）；(iii) 您不支付应付给颐阳智能或任何其他方的与您使用本服务相关的任何费用或其他款项；(iv) 本服务（或其任何部分）需终止或进行重大修改；或 (v) 意外突发的技术、安全问题或进行大量不支持操作；(vi) 我们对政府机构的命令或要求的遵守。\n\n在大多数情况下，如果我们选择关闭您的帐户，我们将通过您提供的电子邮件地址至少提前 30 天通知您，以便您取回存储在本服务之服务器上的任何内容（除非我们确定法律禁止我们提供此类通知或者法律禁止您这样做）。本通知期届满后，您将无法取回该帐户中包含的内容或以其他方式使用本服务。\n我离世之后，我的账户会怎样？\n\n颐阳智能对保护您内容的隐私的承诺在您离世之后或丧失能力之后都会继续。如果您希望在您不能再向别人提供对您的内容或账户信息的访问之后使某人能够访问您的内容或账户信息，您需要主动地为向其提供您的账户信息执行一个流程。我们不会将您的账户信息或您的内容，提供给任何人，甚至是近亲，除非我们确定我们在法律上有义务这样做。我们鼓励您在您的遗嘱或其他遗产计划中涵括您的账户信息和如何访问您的内容的说明，这样任何您希望让其访问您账户的人将知道如何操作。敬请阅读我们的商业条款，了解在死亡或丧失行为能力后停止订购付费帐户的信息。\n如果我有绝妙的想法要与颐阳智能分享，我有什么权利？\n\n当您通过“联系我们”、用户论坛或支持界面，或通过任何其他途径向颐阳智能提交有关本服务（或其他产品或服务）的任何意见、建议、文件和/或提议（统称“贡献”）时，您承认并同意：(i) 您的贡献不包含机密或专有信息；(ii) 颐阳智能对此贡献在任何时间内均不承担任何明示或暗示的保密义务；(iii) 颐阳智能应有权出于任何目的以任何方式使用或披露（或选择不使用或披露）此类贡献；(iv) 颐阳智能可能已经在考虑或正在开发与此贡献类似的东西；(v) 您的贡献自动成为颐阳智能的财产，且颐阳智能对您不承担任何义务；及 (vi) 在任何情况下，您无权从颐阳智能获得任何形式的解释、赔偿或补偿。\n颐阳智能投放广告吗？\n\n我们的商业模式旨在赋予本服务宝贵的价值，从而让我们的用户愿意订购付费服务。但我们可能会展示服务的或与其相关的广告和促销活动，其中一些可能由第三方付费。我们还会在颐阳智能软件中发布公告。这些信息可能宣传其他颐阳智能产品、服务（包括Evernote Market）和活动，展示我们服务的各项用途，并推广与颐阳智能合作的某些第三方应用程序和服务，通过使用本服务和在Evernote Market中购买任何产品，您同意接收上述广告、推销和公告。我们向您承诺，我们不会以向您投放广告为目的而对您的内容做任何数据挖掘。更多信息请参阅隐私政策。\n\n由于我们提供的某些广告或其他信息内容将基于第三方提供的信息，我们不对任何广告或其他信息给您带来的任何种类的任何损失或损害承担任何责任或义务，除非适用的法律法规另有规定。此外，您与在服务中发现的广告商或通过本服务与广告商之间进行的互动，包括但不限于，对广告的所有信赖、所有与之相关的商业交易和法律义务仅限于您与该广告商之间。\n我还需要知道什么？\n第三方链接、内容及编程。\n\n我们可能涵盖或推荐第三方资源、材料和开发商和/或指向第三方网站、内容和应用程序的链接作为服务的组成部分，或涵盖或推荐与服务相关的第三方资源、材料和开发商和/或指向第三方网站、内容和应用程序的链接。我们无法控制这些网站或开发商或仅对其具有极其有限的控制，因此，您承认并同意：(i) 我们对此类外部网站、内容或应用程序的可用性不承担任何责任；(ii) 我们对该等网站或应用程序提供的任何内容或其他材料或性能不承担任何责任或义务；(iii) 我们不直接或间接地承担任何因使用或信赖任何此类内容、材料或应用程序导致的、声称因该等使用或信赖导致的、或与该等使用或信赖有关的任何损害或损失。\n赔偿。\n\n因与您对本服务的任何部分的使用、对本服务条款的任何违约或与您使用本服务相关的任何其他行为（包括账户中采取的所有行为）有关的任何第三方索赔所造成的或与第三方索赔通过任何方式相关的任何及所有索赔、负债、损害（实际和间接）、损失和开支（包括法律及其他专业费用）的损害，您同意赔偿颐阳智能、其子公司、关联公司、管理人员、代理人、员工、广告商和合作伙伴，并保证使颐阳智能、其子公司、关联公司、管理人员、代理人、员工、广告商和合作伙伴免受该等索赔、负债、损害（实际和间接）、损失和开支（包括法律及其他专业费用）的损害。如果出现此类索赔，我们将向我们拥有的该账户中的联系信息提供此索赔、起诉和诉讼的通知，但是如通知未能向您送达，本协议项下您的赔偿义务并不会因此得以消除或减轻。\n责任限制。\n\n在法律允许的最大范围内，本服务“按原样”提供。\n\n您明确理解并同意：\n\n(a) 您使用本服务或购买并使用任何产品之风险完全由您自行承担。本服务基于“原样”及“现有”的基础提供，且产品基于“原样”及“现有”的基础出售。在法律允许的最大范围内，颐阳智能明确否认任何形式的所有明示或暗示的保证及条件，包括但不限于，适销性、针对特定用途的适用性和无侵权的默示保证和条件。\n\n(b) 颐阳智能不保证(i) 本服务将满足您的所有需求；(ii) 本服务将不间断、及时、安全或无错误；或(iii) 颐阳智能软件或服务中的所有错误将被纠正。\n\n(c) 任何通过使用本服务下载的材料、通过Evernote Market购买的产品或通过其他方式获得的材料和产品由您自己全权决定并自担风险，并且您承担因下载或使用此类材料而造成您的计算机或其他设备的损害或数据丢失的完全责任。\n\n(d) 您从颐阳智能或通过或从本服务所获得的任何建议或信息，无论口头还是书面，均不构成本服务条款中未明确规定的任何保证。\n\n您明确理解并同意，对于以下情形造成的任何直接、间接、附带、特别、衍生性或惩罚性损害赔偿，包括但不限于，利润损失、商誉、使用、数据、购买替代物或其他无形损失的损害赔偿（即使颐阳智能已被告知发生此类损害赔偿的可能性），颐阳智能、其子公司、关联公司、许可方以及本公司及其各自的管理人员、雇员、代理人和承继者均不对您承担责任：(i) 使用或无法使用本服务；(ii) 因通过本服务或从本服务购买或获得的任何商品、产品、数据、信息或服务、或者收到的信息或订立的交易产生的替代商品和服务的采购成本；(iii) 对您的传输、内容或数据未经授权的访问或损失、损坏或更改；(iv) 在本服务中或使用本服务的任何第三方的声明或行为，或提供有关服务运营或Evernote Market的任何服务；(v)颐阳智能依赖于您的账户信息及其任何变更以及从其收到的通知的作为或不作为；(vi) 您无法保护任何密码的机密性或您的账户信息的访问权限；(vii) 使用本服务或与本服务集成、或者在Evernote Market提供产品的任何第三方的作为或不作为；(viii) 任何广告内容或您购买或使用任何广告的或其他第三方的产品或服务；(ix) 根据本服务条款的条款终止您的账户，或(x) 与本服务有关的任何其他事项。\n排除和限制。\n\n本服务条款(包括责任限制的规定)中不存在任何意图排除或限制任何根据法律不得排除或限制的条件、保证、权利或责任的条款。因此，您仅适用中华人民共和国合法的责任和其他限制，并且我们的责任以法律允许的最大范围为限。\n如果颐阳智能必须发送某些事项的通知给我，会如何通知？\n\n这是务必确保您的账户信息准确、完整和更新的另一个原因。我们可能通过电子邮件(您同账户关联的邮件地址)、常规邮件或在受影响的服务的网站上发布信息的方式向您发出通知。\n我如何发送通知给颐阳智能？\n\n除非本条款或任何独立协议特别指定使用不同的方式或地址给颐阳智能发送通知，任何发给颐阳智能的通知必须发送至电子邮件地址legalnotice@yinxiang.com。此电子邮件地址可能会作为本服务条款的任何更新的组成部分进行更新。如果您不能通过电子邮件提供通知，可以寄送通知至以下地址：\n\n中华人民共和国北京市北四环西路58号理想国际大厦705室，邮编100080\n我对颐阳智能的使用适用哪些法律？\n\n您和颐阳智能之间的本条款和关系将受中华人民共和国法律管辖。\n\n如果具有管辖权的法院认为本服务条款的任何规定无效，各方仍然同意，法院应努力使得条款所体现的各方意图得以实现，且本服务条款的其他规定仍然具有充分效力及作用。\n如果我认为要对颐阳智能提出索赔时，该如何做？\n告诉我们您的投诉。\n\n我们想知道您是否有任何意见，如果您对本服务或任何颐阳智能软件的操作有任何问题，我们建议您联系我们的用户支持团队，我们希望能确保您可享受卓越体验。\n启动正式索赔。\n\n如果您认定我们并没有解决您的顾虑并且您必须采取法律行动，您同意您的索赔须通过本条款规定的流程解决。您同意，在向颐阳智能提起任何正式诉讼之前，您将通过legalnotice@yinxiang.com向我们的律师发送通知并说明您在发送“争议通知”。在收到争议通知后，您和我们应在争议通知发送之日起的六十(60) 天之内尝试通过非正式谈判解决争议。如果争议仍未解决，您或我们可将本服务条款解释和执行引起的争议提交至北京的具管辖权的法院启动正式诉讼程序。\n索赔时效。\n\n请注意，因使用本服务或与使用本服务相关而产生或其他根据本条款而产生的任何索赔或诉因，适用相关法律规定的诉讼时效。\n其他事项\n\n最后还有几个要点。首先，本条款构成您和颐阳智能之间的全部协议，并管辖您对本服务的使用，除非您已订立独立协议，并仅以此为限。本条款将取代您和颐阳智能之间为截至本条款顶部指示的有效日期使用本服务订立的任何之前的协议或本条款的更早版本。如果通过访问或使用本服务，您使用或获得来自第三方的任何产品或服务，您可能还受该第三方适用于该等产品或服务的条款和条件的约束，本条款将不影响您与该第三方的法律关系。\n\n其次，请理解本服务有别于Evernote Corporation (www.evernote.com) (“Evernote”)所提供的服务。颐阳智能服务从中国北京提供，旨于在中国内使用。在本协议项下，您并未获得使用Evernote服务或软件的任何权利。并且，此外，如果您选择同时使用颐阳智能和Evernote提供的服务，您确认，您在各自服务的内容将作为完全独立且不同的内容，由颐阳智能和Evernote分别处理，由于两种服务不以任何方式整合，且分别受针对各服务的服务条款和隐私政策管辖。\n\n最后，本服务条款中的章节标题仅为方便检索而设，不具有任何法律或合同效力。\n";
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.CustomTitle);
			SetContentView (Resource.Layout.ServiceAgreeLayout);
			Window.SetFeatureInt (WindowFeatures.CustomTitle, Resource.Layout.custom_title_bar);
			// Create your application here
			InitView();
		}

		private void InitView()
		{
			//设置标题栏
			var btn_header_back = FindViewById<Button> (Resource.Id.btn_header_back);
			btn_header_back.Click += (sender, e) => 
			{
				this.Finish();
			};
				
			FindViewById<TextView> (Resource.Id.tv_header_title).Text = "服务条款协议";

			var tv_serviceAgree = FindViewById<TextView> (Resource.Id.tv_service_agree);
			tv_serviceAgree.Text = strServiceAgree;

		}
	}
}

