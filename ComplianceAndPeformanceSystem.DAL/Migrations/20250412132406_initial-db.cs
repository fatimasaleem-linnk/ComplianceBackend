using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initialdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryLookup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComplianceNotificationMassage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageTitleAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageTitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageBodyAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageBodyEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplianceNotificationMassage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LookupValue",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    ValueEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LookupValueCategory_CategoryID",
                        column: x => x.CategoryId,
                        principalTable: "CategoryLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComplianceRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Seq = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignTaskNameEn = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AssignTaskNameAr = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RemainingDays = table.Column<int>(type: "int", nullable: false),
                    AssignedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassedDays = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<long>(type: "bigint", nullable: false),
                    LastSendDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplianceRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComplianceRequest_StatusId",
                        column: x => x.StatusId,
                        principalTable: "LookupValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComplianceApproval",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComplianceRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApprovalUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaysForFinish = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplianceApproval", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComplianceApprovals_ComplianceRequestId",
                        column: x => x.ComplianceRequestId,
                        principalTable: "ComplianceRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComplianceDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Seq = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplianceRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicensedEntityId = table.Column<long>(type: "bigint", nullable: false),
                    ActivityId = table.Column<long>(type: "bigint", nullable: false),
                    PlantNameId = table.Column<long>(type: "bigint", nullable: false),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    QuarterPlannedForVisitId = table.Column<long>(type: "bigint", nullable: true),
                    VisitTypeId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplianceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComplianceDetails_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "LookupValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComplianceDetails_ComplianceRequestId",
                        column: x => x.ComplianceRequestId,
                        principalTable: "ComplianceRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComplianceDetails_LicensedEntityId",
                        column: x => x.LicensedEntityId,
                        principalTable: "LookupValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComplianceDetails_LocationId",
                        column: x => x.LocationId,
                        principalTable: "LookupValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComplianceDetails_PlantNameId",
                        column: x => x.PlantNameId,
                        principalTable: "LookupValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComplianceDetails_QuarterPlannedForVisitId",
                        column: x => x.QuarterPlannedForVisitId,
                        principalTable: "LookupValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComplianceDetails_VisitTypeId",
                        column: x => x.VisitTypeId,
                        principalTable: "LookupValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComplianceSpecialist",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComplianceRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialistUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialistUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialistUserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplianceSpecialist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComplianceSpecialists_ComplianceRequestId",
                        column: x => x.ComplianceRequestId,
                        principalTable: "ComplianceRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComplianceRequestActivity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComplianceRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByUserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailsAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailsEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplianceDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplianceRequestActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComplianceRequestActivity_ComplianceDetails_ComplianceDetailsId",
                        column: x => x.ComplianceDetailsId,
                        principalTable: "ComplianceDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ComplianceRequestActivity_ComplianceRequestId",
                        column: x => x.ComplianceRequestId,
                        principalTable: "ComplianceRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CategoryLookup",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1L, "المرخص له", "Licensed Entity" },
                    { 2L, "النشاط", "Activity" },
                    { 3L, "اسم المحطة", "Plant Name" },
                    { 4L, "الموقع", "Location" },
                    { 5L, "الربع المخطط له", "Quarter Planned For Visit" },
                    { 6L, "نوع الزيارة", "Visit Type" },
                    { 7L, "حالة الخطة", "Plan Status" }
                });

            migrationBuilder.InsertData(
                table: "ComplianceNotificationMassage",
                columns: new[] { "Id", "ActionUrl", "MessageBodyAR", "MessageBodyEn", "MessageTitleAR", "MessageTitleEn", "MessageType", "Role" },
                values: new object[,]
                {
                    { 1, "/", "يرجي التدخل لإدراج احد المتخصين لوضع الخطة من الرابط ادناه", "Please intervene to include a specialist to develop the plan from the link below", "يمكنك الأن تعيين احد الأخصائين لإدارج الخطة السنوية", "You can now appoint a specialist to include the annual plan.", "Info", "ComplianceManager" },
                    { 2, "/", "يرجي التدخل لإدراج احد المتخصين لوضع الخطة من الرابط ادناه", "Please intervene to include a specialist to develop the plan from the link below", "يمكنك الأن تعيين احد الأخصائين لإدارج الخطة السنوية", "You can now appoint a specialist to include the annual plan.", "Error", "ComplianceManager" },
                    { 3, "/", " وهي جاهزة لمراجعتك واعتمادك حيث ان الوقت المخصص للمراجعة هو ٧ ايام", "It is ready for your review and approval, as the review time is 7 days.", "خطة الامتثال السنوية الجديدة المقدمة للمراجعة", "New Annual Compliance Plan Submitted for Review", "Info", "ComplianceManager" },
                    { 4, "/", " يرجي الانتهاء من مراجعة الخطة في الوقت المحدد حيث ان ذلك يسهل ويساعد علي اكتمال المراحل القادمة بشكل جيد", "Please complete the plan review on time as this will facilitate and help complete the next stages well.", "الوقت المتبقي للإنتهاء من مراجعتك للخطة الزمنية هو ٥ ايام", "The time remaining to complete the review of the timeline is 5 days.", "Info", "ComplianceManager" },
                    { 5, "/", " يرجى التأكد من إكمال جميع الخطوات المطلوبة، وتقديم الخطة في الوقت المحدد يعد تقديمك في الوقت المناسب أمرًا بالغ الأهمية لتحقيق أهداف الامتثال\r\nإذا كنت بحاجة إلى مساعدة، يرجى الاتصال بمديرك على الفور للحصول على الخطة في الرابط ادناه", "Please ensure you complete all required steps and submit the plan on time. Your timely submission is critical to achieving compliance goals. If you need assistance, please contact your manager immediately to obtain the plan at the link below.", "هذا تذكير نهائي بأن الموعد النهائي لتقديم خطة الامتثال السنوية لا يزال على بعد يومين فقط.", "This is a final reminder that the deadline for submitting your annual compliance plan is just two days away.", "Error", "ComplianceManager" },
                    { 6, "/", "يرجى التأكد من إكمال جميع الخطوات المطلوبة، وتقديم الخطة في الوقت المحدد يعد تقديمك في الوقت المناسب أمرًا بالغ الأهمية لتحقيق أهداف الامتثال\r\nإذا كنت بحاجة إلى مساعدة، يرجى الاتصال بمديرك على الفور للحصول على الخطة في الرابط ادناه", "Please ensure you complete all required steps and submit the plan on time. Your timely submission is critical to achieving compliance goals. If you need assistance, please contact your manager immediately to obtain the plan at the link below.", "نأسف لإبلاغك بأن مراجعة الخطة الامتثال السنوية لم يكتمل في الإطار الزمني المحدد لذا سيتم تصعيد الأمر للمدير العام .", "We regret to inform you that the annual compliance plan review was not completed within the specified time frame and therefore the matter will be escalated to the General Manager.", "Error", "ComplianceManager" },
                    { 7, "/", "يرجي العلم ان دور المدير هنا متلقي للاشعارات فقط ولا يمكنه الدخول للخطة لاجراء اي تعديلات عليها", "Please note that the role of the manager here is to receive notifications only and cannot access the plan to make any changes to it.", "الاخصائي  قد تلقى تعديلات من المدير العام لمراقبة الاداء", "The specialist has received modifications from Performance Monitoring Manager.", "Info", "ComplianceManager" },
                    { 8, "/", "يرجي العلم ان دور المدير هنا متلقي للاشعارات فقط ولا يمكنه الدخول للخطة لاجراء اي تعديلات عليها", "Please note that the role of the manager here is to receive notifications only and cannot access the plan to make any changes to it.", "الاخصائي  قد ارسل الخطة بعد التعديل الى المدير العام لمراقبة الاداء", "The specialist sent the modified plan to Performance Monitoring Manager.", "Info", "ComplianceManager" },
                    { 9, "/", "يرجي  التدخل لضمان مراجعة الخطة يتطلب الأمر اهتمامًا فوريًا لحل هذه المهمة المتأخرة.", "Please intervene to ensure the plan is reviewed. Immediate attention is required to resolve this delayed task.", "انتهت فترة مراجعة خطة الامتثال السنوية بعنوان {{PlanTitle}} دون اتخاذ أي إجراء.", "The annual compliance plan review period for {{PlanTitle}} has ended without any action.", "Info", "PerformanceMonitoringManager" },
                    { 10, "/", "يرجي التدخل لضمان مراجعة الخطة يتطلب الأمر اهتمامًا لمراجة الخطة بشكل كامل واعتمادها او ارجعها الي الاخصايئ للعمل التعديلات", "Please intervene to ensure the plan is reviewed. It requires attention to review the plan completely and approve it or return it to the specialist to make amendments.", "تم عمل خطة الامتثال السنوي من قبل الاخصائي وقبولها من قبل المدير المسؤول الخطة جاهزة لمراجعتك خلال ٧ ايام ", "The annual compliance plan has been prepared by the specialist and accepted by the responsible manager. The plan is ready for your review within 7 days.", "Info", "PerformanceMonitoringManager" },
                    { 11, "/", "يرجى التأكد من إكمال جميع الخطوات المطلوبة، وتقديم الخطة في الوقت المحدد يعد تقديمك في الوقت المناسب أمرًا بالغ الأهمية لتحقيق أهداف الامتثال\r\nإذا كنت بحاجة إلى مساعدة، يرجى الاتصال بمديرك على الفور للحصول على الخطة في الرابط ادناه", "Please ensure you complete all required steps and submit the plan on time. Your timely submission is critical to achieving compliance goals. If you need assistance, please contact your manager immediately to obtain the plan at the link below.", "هذا تذكير نهائي بأن الموعد النهائي لتقديم خطة الامتثال السنوية لا يزال على بعد يومين فقط. ", "This is a final reminder that the deadline for submitting your annual compliance plan is just two days away.", "Error", "PerformanceMonitoringManager" },
                    { 12, "/", "يرجى التأكد من إكمال جميع الخطوات المطلوبة، وتقديم الخطة في الوقت المحدد يعد تقديمك في الوقت المناسب أمرًا بالغ الأهمية لتحقيق أهداف الامتثال\r\nإذا كنت بحاجة إلى مساعدة، يرجى الاتصال بمديرك على الفور للحصول على الخطة في الرابط ادناه", "Please ensure you complete all required steps and submit the plan on time. Your timely submission is critical to achieving compliance goals. If you need assistance, please contact your manager immediately to obtain the plan at the link below.", "نأسف لإبلاغك بأن مراجعة خطة الامتثال السنوية لم تكتمل في الإطار الزمني المحدد لذا فضلاً يرجي الانتهاء منها في اقرب وقت", "We regret to inform you that the review of the annual compliance plan was not completed within the specified time frame, so please complete it as soon as possible.", "Info", "PerformanceMonitoringManager" },
                    { 13, "/", "يتعين عليك جمع وتحليل البيانات ذات الصلة، واستكمال التقييمات اللازمة، والبدء في صياغة الخطة في النظام. ويجب إكمال عملية الإعداد في غضون 60 يوم عمل بدءًا من اليوم للوصول إلى نموذج إعداد خطة الامتثال، ", "You must collect and analyze relevant data, complete the necessary assessments, and begin drafting the plan in the system. The preparation process must be completed within 20 business days from today to access the compliance plan preparation form.", "إبدأ الخطة", "Start Plan", "Info", "ComplianceSpecialist" },
                    { 14, "/", "يتعين عليك جمع وتحليل البيانات ذات الصلة، واستكمال التقييمات اللازمة، والبدء في صياغة الخطة في النظام. ويجب إكمال عملية الإعداد في غضون 60 يوم عمل بدءًا من اليوم للوصول إلى نموذج إعداد خطة الامتثال، ", "You must collect and analyze relevant data, complete the necessary assessments, and begin drafting the plan in the system. The preparation process must be completed within 20 business days from today to access the compliance plan preparation form.", "إبدأ الخطة", "Start Plan", "Error", "ComplianceSpecialist" },
                    { 15, "/", "قبل الموعد النهائي. يرجى التأكد من الانتهاء من المسودة وإرسالها في غضون الإطار الزمني المخصص وهو 60 يومًا للوصول إلى مسودتك ومواصلة العمل عليها، انقر فوق الرابط", "Before the deadline. Please ensure you complete and submit your draft within the allotted 60-day timeframe. To access your draft and continue working on it, click the link.", "يمكنك استئناف تحرير خطتك واستكمالها في أي وقت قبل الموعد النهائي", "You can resume editing and completing your plan at any time before the deadline.", "Info", "ComplianceSpecialist" },
                    { 16, "/", "يرجى التأكد من إكمال جميع الخطوات المطلوبة، وتقديم الخطة في الوقت المحدد يعد تقديمك في الوقت المناسب أمرًا بالغ الأهمية لتحقيق أهداف الامتثال\r\nإذا كنت بحاجة إلى مساعدة، يرجى الاتصال بمديرك على الفور للحصول على الخطة في الرابط ادناه", "Please ensure you complete all required steps and submit the plan on time. Your timely submission is critical to achieving compliance goals. If you need assistance, please contact your manager immediately to obtain the plan at the link below.", "هذا تذكير نهائي بأن الموعد النهائي لتقديم خطة الامتثال السنوية لا يزال على بعد 5 أيام فقط.", "This is a final reminder that the deadline for submitting your annual compliance plan is still just 5 days away.", "Warning", "ComplianceSpecialist" },
                    { 17, "/", "يرجى التأكد من إكمال جميع الخطوات المطلوبة، وتقديم الخطة في الوقت المحدد يعد تقديمك في الوقت المناسب أمرًا بالغ الأهمية لتحقيق أهداف الامتثال\r\nإذا كنت بحاجة إلى مساعدة، يرجى الاتصال بمديرك على الفور للحصول على الخطة في الرابط ادناه", "Please ensure you complete all required steps and submit the plan on time. Your timely submission is critical to achieving compliance goals. If you need assistance, please contact your manager immediately to obtain the plan at the link below.", "هذا تذكير نهائي بأن الموعد النهائي لتقديم خطة الامتثال السنوية لا يزال على بعد 3 أيام فقط.", "This is a final reminder that the deadline for submitting your annual compliance plan is still just 3 days away.", "Error", "ComplianceSpecialist" },
                    { 18, "/", "يرجى التأكد من إكمال جميع الخطوات المطلوبة، وتقديم الخطة في الوقت المحدد يعد تقديمك في الوقت المناسب أمرًا بالغ الأهمية لتحقيق أهداف الامتثال\r\nإذا كنت بحاجة إلى مساعدة، يرجى الاتصال بمديرك على الفور للحصول على الخطة في الرابط ادناه", "Please ensure you complete all required steps and submit the plan on time. Your timely submission is critical to achieving compliance goals. If you need assistance, please contact your manager immediately to obtain the plan at the link below.", "نأسف لإبلاغك بأن تقديم خطة الامتثال السنوية لم يكتمل في الإطار الزمني المحدد لذا سيتم تصعيد الأمر للمدير العام.", "We regret to inform you that the submission of the annual compliance plan was not completed within the specified timeframe, so the matter will be escalated to the General Manager.", "Error", "ComplianceSpecialist" },
                    { 19, "/", "جاري المراجعة الأن من قبل المدير المباشر نشكركم لإرسال الخطة ", "The plan is currently being reviewed by the direct manager. Thank you for submitting the plan.", "حالة مراجعة خطة الزيارات", "Visit Plan Review Status", "Info", "ComplianceSpecialist" },
                    { 20, "/", "", "", "تمت الموافقة على الخطة من قبل مدير الادارة", "The plan has been approved by the Compliance Manager.", "Approval", "ComplianceSpecialist" },
                    { 21, "/", "", "", "تمت الموافقة على الخطة من قبل مدير عام مراقبة الالتزام", "The plan was approved by the Performance Monitoring Manager.", "Success", "ComplianceSpecialist" },
                    { 22, "/", "جاري المراجعة الأن من قبل المدير العام لمراقبة الاداء نشكركم لإرسال الخطة ", "The plan is currently being reviewed by the Performance Monitoring Manager.. Thank you for submitting the plan.", "حالة مراجعة خطة الزيارات", "Visit Plan Review Status", "Info", "ComplianceSpecialist" },
                    { 23, "/", "وسبب الارجاع {{ReturnReason}}", "Return reason is {{ReturnReason}}", " تمت اعادة الخطة من قبل مدير الادارة ", "The plan has been Returned by the Compliance Manager an.", "Approval", "ComplianceSpecialist" },
                    { 24, "/", "وسبب الارجاع {{ReturnReason}}", "Return reason is {{ReturnReason}}", "تمت اعادة الخطة من قبل مدير عام مراقبة الالتزام ", "The plan has been Returned by the Performance Monitoring Manager.", "Success", "ComplianceSpecialist" }
                });

            migrationBuilder.InsertData(
                table: "LookupValue",
                columns: new[] { "Id", "CategoryId", "CreatedByEmail", "CreatedByID", "CreatedByUserName", "CreatedOn", "IsDeleted", "ModifiedByEmail", "ModifiedByID", "ModifiedByUserName", "ModifiedOn", "ValueAr", "ValueEn" },
                values: new object[,]
                {
                    { 1L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2799), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2811), "مرافق البحر الأحمر المشتركة", "Red Sea Joint Facilities" },
                    { 2L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2814), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2816), "نيوم", "NEOM" },
                    { 3L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2818), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2819), "شركة المياه الوطنية", "National Water Company" },
                    { 4L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2821), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2821), "شركة الفتح الدولية لأعمال المياه والكهرباء", "Al-Fath International Water and Electricity Works Company" },
                    { 5L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2823), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2824), "المؤسسة العامة لتحلية مياه الشرب", "Public Corporation for Potable Water Conversion" },
                    { 6L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2827), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2828), "شركة الركاب للكهرباء في الجبيل وينبع", "Al-Rakab Electricity Company in Jubail and Yanbu" },
                    { 7L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2830), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2831), "شركة مشروع شيبة لتنمية المياه", "Shaiba Project Company for Water Development" },
                    { 8L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2832), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2833), "الشركة الشقيقة الثالثة", "Third Sister Company" },
                    { 9L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2835), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2836), "شركة رابغ الثالثة", "Rabigh Third Company" },
                    { 10L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2839), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2840), "الشركة السعودية لشراكات المياه", "Saudi Water Partnership Company" },
                    { 11L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2842), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2842), "شركة محطة العلم العلمية", "Al-Alam Scientific Station Company" },
                    { 12L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2844), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2845), "شركة جزالة", "Jazalah Company" },
                    { 13L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2847), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2848), "كندا", "Canada" },
                    { 14L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2849), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2850), "سواكو", "SWACO" },
                    { 15L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2852), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2853), "شركة شاس للمقاولات", "Shas Contracting" },
                    { 16L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2854), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2855), "شركة شاس لخدمات المياه", "Shas Water Services" },
                    { 17L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2857), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2858), "درر أبشر", "Durar Absher" },
                    { 18L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2861), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2862), "شركة عبد العزيز بن عثمان بن سلمة وشركاؤه للمياه", "Abdulaziz bin Othman bin Salma and Partners Water Company" },
                    { 19L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2863), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2864), "شركة عبد العزيز بن عثمان بن سلمة وشركاؤه للتجارة", "Abdulaziz bin Othman bin Salma and Partners for Trade" },
                    { 20L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2874), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2875), "المقاولات والنقل", "Contracting and Transport" },
                    { 21L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2876), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2877), "مؤسسة عبد الله محمد السعد لتحلية المياه", "Abdullah Mohammed Al-Saad Water Desalination Establishment" },
                    { 22L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2879), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2880), "مؤسسة عبد الرزاق العبد الكريم علي بن عبد الرزاق العبد الكريم للمقاولات", "Abdulrazaq Al-Abdulkarim Ali bin Abdulrazaq Al-Abdulkarim Contracting Establishment" },
                    { 23L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2883), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2884), "حسن عبد الله العماري", "Hassan Abdullah Al-Amari" },
                    { 24L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2886), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2887), "شركة ينبع الدولية للطيران", "Yanbu International Aviation Company" },
                    { 25L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2889), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2890), "شركة نقل وتقنية المياه", "Water Transport and Technology Company" },
                    { 26L, 1L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2892), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2893), "أخرى", "Another" },
                    { 27L, 2L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2894), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2895), "إنتاج المياه المحلاة", "Desalinated water production" },
                    { 28L, 2L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2897), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2898), "معالجة مياه الصرف الصحي", "Wastewater treatment" },
                    { 29L, 2L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2900), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2901), "التخزين الاستراتيجي", "Strategic storage" },
                    { 30L, 2L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2903), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2904), "إنتاج المياه النقية", "Purified water production" },
                    { 31L, 2L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2906), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2906), "التخزين الاستراتيجي", "Strategic storage" },
                    { 32L, 2L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2908), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2909), "توزيع المياه المحلاة والمنقاة", "Desalinated and purified water distribution" },
                    { 33L, 2L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2911), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2912), "المشتري الرئيسي", "Main buyer" },
                    { 34L, 2L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2915), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2916), "المحطات الصغيرة", "Mini-stations" },
                    { 35L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2918), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2918), "RO", "RO" },
                    { 36L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2920), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2921), "محطة معالجة مياه الصرف الصحي ١", "STP1" },
                    { 37L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2923), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2923), "محطة ضباء", "Duba Station" },
                    { 38L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2925), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2926), "محطة سعد", "Saad Station" },
                    { 39L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2928), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2929), "محطة الخبر ١", "Al Khobar Station 1" },
                    { 40L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2931), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2931), "محطة الخبر ٢", "Al Khobar Station 2" },
                    { 41L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2933), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2934), "بريمان - المرحلة ١ و٢", "Breiman Phase 1 and 2" },
                    { 42L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2935), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2936), "لم يُحدد بعد", "TBD" },
                    { 43L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2938), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2939), "خزانات عرعر", "Arar Tanks" },
                    { 44L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2941), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2941), "خزانات طريف", "Turaif Tanks" },
                    { 45L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2943), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2943), "مشروع النرجس", "Al Narjis Project" },
                    { 46L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2945), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2946), "أبها (أم الركب)", "Abha (Umm Al Rukb)" },
                    { 47L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2948), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2949), "خزان بلجرشي", "Baljurashi Tank" },
                    { 48L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2951), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2952), "خزان جازان", "Jazan Tank" },
                    { 49L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2954), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2954), "محطة تحلية مياه البحر الفاتح", "Al Fateh Seawater Desalination Plant" },
                    { 50L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2956), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2957), "جدة RO٣", "Jeddah RO3" },
                    { 51L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2959), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2960), "محطة تحلية مياه الخبر RO٢", "Al Khobar RO 2" },
                    { 52L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2961), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2962), "محطة تحلية مياه البحر في مدينة الجبيل الصناعية - المرحلة ١", "Jubail Industrial City SWRO Stage 1" },
                    { 53L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2964), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2965), "المرحلتان ٢-٣", "Stage 2-3" },
                    { 54L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2967), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2968), "المرحلة ٥", "Stage 5" },
                    { 55L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2969), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2970), "شبكة مياه الشرب", "Drinking Water Network" },
                    { 56L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2972), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2973), "خزانات مياه ينبع العامة في مشروع تطوير مياه الشعيبة - المرحلة السادسة", "Yanbu PRW Tanks at PSDP-6" },
                    { 57L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2975), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2976), "شركة مشروع تطوير مياه الشعيبة الثاني", "Shuaiba 2nd Water Development Project Company" },
                    { 58L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2977), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2978), "شركة الشقيق الثالثة للمياه", "Al Shuqaiq 3rd Water Company" },
                    { 59L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2990), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2992), "شركة رابغ الثالثة", "Rabigh 3rd Company" },
                    { 60L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2994), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2994), "العقود", "Contracts" },
                    { 61L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2996), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2997), "محطة مياه الطائف المستقلة", "Taif Independent Water Plant" },
                    { 62L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2999), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(2999), "محطة جزلة", "Jazlah Station" },
                    { 63L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3001), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3002), "محطة رابغ", "Rabigh Station" },
                    { 64L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3004), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3005), "محطة ميناء جدة الإسلامي", "Jeddah Islamic Port Station" },
                    { 65L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3006), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3007), "أبحر الشمالية", "North Obhur" },
                    { 66L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3010), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3011), "محطة إنتاج ومعالجة مياه شآس", "Shaas Water Production and Treatment Plant" },
                    { 67L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3013), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3014), "شركة شآس لخدمات المياه المحدودة", " Shaas Water Services Company Limited" },
                    { 68L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3015), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3016), "محطة تحلية المقبل", "Al Muqbil Desalination Plant" },
                    { 69L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3018), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3019), "شركة عبد العزيز بن سلمى", "Abdulaziz Bin Salma Company" },
                    { 70L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3020), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3021), "شركة عبد العزيز بن سلمى، محطة سعد", "Abdulaziz Bin Salma Company, Saad Station" },
                    { 71L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3023), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3024), "محطة عبد الكريم", "Abdulkarim Station" },
                    { 72L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3026), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3027), "المحطة ١", "Station 1" },
                    { 73L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3028), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3029), "محطة ينبع المستقلة لإنتاج المياه", "Yanbu Independent Water Production Plant" },
                    { 74L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3031), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3032), "شبكة الجبيل", "Jubail System" },
                    { 75L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3034), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3034), "نظام رأس الخير", "System Ras Al Khair" },
                    { 76L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3036), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3037), "نظام ينبع - المدينة المنورة", "Yanbu - Madinah System" },
                    { 77L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3039), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3040), "نظام نقل الشقيق", "Shaqiq Transport System" },
                    { 78L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3042), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3043), "نظام نقل الشعيبة", "Shuaiba Transport System" },
                    { 79L, 3L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3044), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3045), "نظام نقل رابغ", "Rabigh Transport System" },
                    { 80L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3047), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3048), "أملج", "Umluj" },
                    { 81L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3050), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3051), "ضباء", "Duba" },
                    { 82L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3053), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3053), "سعد", "Saad" },
                    { 83L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3055), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3056), "المدينة المنورة", "Al-Madinah" },
                    { 84L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3058), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3059), "عرعر", "Arar" },
                    { 85L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3061), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3061), "طريف", "Tarif" },
                    { 86L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3063), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3064), "الرياض", "Riyadh" },
                    { 87L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3066), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3067), "أبها", "Abha" },
                    { 88L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3069), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3069), "الباحة", "Al-Baha" },
                    { 89L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3071), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3072), "جازان", "Jazan" },
                    { 90L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3074), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3075), "جدة", "Jeddah" },
                    { 91L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3077), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3077), "الخبر", "Al-Khobar" },
                    { 92L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3079), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3080), "رابغ", "Rabigh" },
                    { 93L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3082), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3082), "الطائف", "Taif" },
                    { 94L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3090), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3091), "الجبيل", "Jubail" },
                    { 95L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3093), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3095), "رابغ", "Rabigh" },
                    { 96L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3097), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3098), "جدة", "Jeddah" },
                    { 97L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3099), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3100), "رأس الخير", "Ras Al-Khair" },
                    { 98L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3102), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3102), "ينبع-المدينة المنورة", "Yanbu-Al-Madinah" },
                    { 99L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3104), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3105), "الشقيق", "Al-Shaqiq" },
                    { 100L, 4L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3107), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3108), "الشعيبة", "Al-Shuaiba" },
                    { 101L, 5L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3110), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3111), "الربع الأول", "First Quarter" },
                    { 102L, 5L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3112), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3113), "الربع الثاني", "Second Quarter" },
                    { 103L, 5L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3115), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3116), "الربع الثالث", "Third Quarter" },
                    { 104L, 5L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3118), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3119), "الربع الرابع", "Fourth Quarter" },
                    { 105L, 6L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3121), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3121), "روتينية", "routine" },
                    { 106L, 6L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3123), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3124), "متابعة", "follow-up" },
                    { 107L, 6L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3126), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3127), "شكوى", "complaint" },
                    { 108L, 7L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3128), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3129), "جديد", "New" },
                    { 109L, 6L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3131), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3132), "قيد الانتظار والمراجعة مدير الاداره", "Pending Review  the Compliance Manager" },
                    { 110L, 6L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3134), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3135), "قيد الانتظار والمراجعة مدير عام مراجعة الاداء", "Pending Review the Performance Monitoring Manager" },
                    { 111L, 6L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3136), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3137), "قبول المدير الادارة", "Approval of Compliance Manager" },
                    { 112L, 6L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3139), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3140), "قبول مدير عام مراجعة الاداء", "Approval of the Performance Monitoring Manager" },
                    { 113L, 6L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3141), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3142), "ارجاع من المدير الادارة", "Return Plan of Compliance Manager" },
                    { 114L, 6L, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3144), null, null, null, null, new DateTime(2025, 4, 12, 16, 24, 5, 895, DateTimeKind.Local).AddTicks(3145), "ارجاع من مدير عام مراجعة الاداء", "Return Plan of the Performance Monitoring Manager" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryLookup_NameAr",
                table: "CategoryLookup",
                column: "NameAr");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryLookup_NameEn",
                table: "CategoryLookup",
                column: "NameEn");

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceApproval_ComplianceRequestId",
                table: "ComplianceApproval",
                column: "ComplianceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceDetails_ActivityId",
                table: "ComplianceDetails",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceDetails_ComplianceRequestId",
                table: "ComplianceDetails",
                column: "ComplianceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceDetails_LicensedEntityId",
                table: "ComplianceDetails",
                column: "LicensedEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceDetails_LocationId",
                table: "ComplianceDetails",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceDetails_PlantNameId",
                table: "ComplianceDetails",
                column: "PlantNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceDetails_QuarterPlannedForVisitId",
                table: "ComplianceDetails",
                column: "QuarterPlannedForVisitId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceDetails_VisitTypeId",
                table: "ComplianceDetails",
                column: "VisitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceRequest_AssignTaskNameAr",
                table: "ComplianceRequest",
                column: "AssignTaskNameAr");

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceRequest_AssignTaskNameEn",
                table: "ComplianceRequest",
                column: "AssignTaskNameEn");

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceRequest_StatusId",
                table: "ComplianceRequest",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceRequestActivity_ComplianceDetailsId",
                table: "ComplianceRequestActivity",
                column: "ComplianceDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceRequestActivity_ComplianceRequestId",
                table: "ComplianceRequestActivity",
                column: "ComplianceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceSpecialist_ComplianceRequestId",
                table: "ComplianceSpecialist",
                column: "ComplianceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_LookupValue_CategoryId",
                table: "LookupValue",
                column: "CategoryId")
                .Annotation("SqlServer:Clustered", false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComplianceApproval");

            migrationBuilder.DropTable(
                name: "ComplianceNotificationMassage");

            migrationBuilder.DropTable(
                name: "ComplianceRequestActivity");

            migrationBuilder.DropTable(
                name: "ComplianceSpecialist");

            migrationBuilder.DropTable(
                name: "ComplianceDetails");

            migrationBuilder.DropTable(
                name: "ComplianceRequest");

            migrationBuilder.DropTable(
                name: "LookupValue");

            migrationBuilder.DropTable(
                name: "CategoryLookup");
        }
    }
}
