using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updatedata4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LicenseNumber",
                table: "ComplianceDetails");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 1,
                column: "MessageBodyAR",
                value: "يرجى التدخل لإدراج احد المختصين لوضع الخطة من الرابط ادناه");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 2,
                column: "MessageBodyAR",
                value: "يرجى التدخل لإدراج احد المختصين لوضع الخطة من الرابط ادناه");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 3,
                column: "MessageBodyAR",
                value: " وهي جاهزة لمراجعتك واعتمادك حيث أن الوقت المخصص للمراجعة هو ٧ أيام");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MessageBodyAR", "MessageTitleAR" },
                values: new object[] { " يرجى الانتهاء من مراجعة الخطة في الوقت المحدد حيث أن ذلك يسهل ويساعد على اكتمال المراحل القادمة بشكل جيد", "الوقت المتبقي للإنتهاء من مراجعتك للخطة الزمنية هو ٥ أيام" });

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 7,
                column: "MessageBodyAR",
                value: "يرجى العلم أن دور المدير هنا متلقي للاشعارات فقط ولا يمكنه الدخول للخطة لاجراء اي تعديلات عليها");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 8,
                column: "MessageBodyAR",
                value: "يرجى العلم أن دور المدير هنا متلقي للاشعارات فقط ولا يمكنه الدخول للخطة لاجراء أي تعديلات عليها");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 9,
                column: "MessageBodyAR",
                value: "يرجى  التدخل لضمان مراجعة الخطة يتطلب الأمر اهتمامًا فوريًا لحل هذه المهمة المتأخرة.");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "MessageBodyAR", "MessageTitleAR" },
                values: new object[] { "يرجى التدخل لضمان مراجعة الخطة يتطلب الأمر اهتمامًا لمراجة الخطة بشكل كامل واعتمادها او ارجعها الي الاخصائي للعمل التعديلات", "تم عمل خطة الامتثال السنوي من قبل الاخصائي وقبولها من قبل المدير المسؤول الخطة جاهزة لمراجعتك خلال ٧ أيام " });

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 12,
                column: "MessageTitleAR",
                value: "نأسف لإبلاغك بأن مراجعة خطة الامتثال السنوية لم تكتمل في الإطار الزمني المحدد لذا فضلاً يرجى الانتهاء منها في اقرب وقت");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 13,
                column: "MessageTitleAR",
                value: "ابدأ الخطة");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 14,
                column: "MessageTitleAR",
                value: "ابدأ الخطة");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 23,
                column: "MessageTitleAR",
                value: " تمت إعادة الخطة من قبل مدير الادارة ");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 24,
                column: "MessageTitleAR",
                value: "تمت إعادة الخطة من قبل مدير عام مراقبة الالتزام  ");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 30,
                column: "MessageBodyAR",
                value: "لقد تم تعيينك في الزيارة {VisitDate} يرجى العلم بان المدة المحددة لتحميل النماذج وارساله لنا في خلال يومين لتحميل النموذج في الرابط ادناه");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 40,
                column: "MessageTitleAR",
                value: "انتهت فترة الموافقة على الخطة");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 41,
                column: "MessageTitleAR",
                value: "انتهت فترة الموافقة على الخطة");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "LicenseNumber",
                table: "ComplianceDetails",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 1,
                column: "MessageBodyAR",
                value: "يرجي التدخل لإدراج احد المتخصين لوضع الخطة من الرابط ادناه");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 2,
                column: "MessageBodyAR",
                value: "يرجي التدخل لإدراج احد المتخصين لوضع الخطة من الرابط ادناه");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 3,
                column: "MessageBodyAR",
                value: " وهي جاهزة لمراجعتك واعتمادك حيث ان الوقت المخصص للمراجعة هو ٧ ايام");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MessageBodyAR", "MessageTitleAR" },
                values: new object[] { " يرجي الانتهاء من مراجعة الخطة في الوقت المحدد حيث ان ذلك يسهل ويساعد علي اكتمال المراحل القادمة بشكل جيد", "الوقت المتبقي للإنتهاء من مراجعتك للخطة الزمنية هو ٥ ايام" });

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 7,
                column: "MessageBodyAR",
                value: "يرجي العلم ان دور المدير هنا متلقي للاشعارات فقط ولا يمكنه الدخول للخطة لاجراء اي تعديلات عليها");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 8,
                column: "MessageBodyAR",
                value: "يرجي العلم ان دور المدير هنا متلقي للاشعارات فقط ولا يمكنه الدخول للخطة لاجراء اي تعديلات عليها");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 9,
                column: "MessageBodyAR",
                value: "يرجي  التدخل لضمان مراجعة الخطة يتطلب الأمر اهتمامًا فوريًا لحل هذه المهمة المتأخرة.");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "MessageBodyAR", "MessageTitleAR" },
                values: new object[] { "يرجي التدخل لضمان مراجعة الخطة يتطلب الأمر اهتمامًا لمراجة الخطة بشكل كامل واعتمادها او ارجعها الي الاخصايئ للعمل التعديلات", "تم عمل خطة الامتثال السنوي من قبل الاخصائي وقبولها من قبل المدير المسؤول الخطة جاهزة لمراجعتك خلال ٧ ايام " });

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 12,
                column: "MessageTitleAR",
                value: "نأسف لإبلاغك بأن مراجعة خطة الامتثال السنوية لم تكتمل في الإطار الزمني المحدد لذا فضلاً يرجي الانتهاء منها في اقرب وقت");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 13,
                column: "MessageTitleAR",
                value: "إبدأ الخطة");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 14,
                column: "MessageTitleAR",
                value: "إبدأ الخطة");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 23,
                column: "MessageTitleAR",
                value: " تمت اعادة الخطة من قبل مدير الادارة ");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 24,
                column: "MessageTitleAR",
                value: "تمت اعادة الخطة من قبل مدير عام مراقبة الالتزام  ");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 30,
                column: "MessageBodyAR",
                value: "لقد تم تعيينك في الزيارة {VisitDate} يرجي العلم بان المدة المحددة لتحميل النماذج وارساله لنا في خلال يومين لتحميل النموذج في الرابط ادناه");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 40,
                column: "MessageTitleAR",
                value: "انتهت فترة الموافقة علي الخطة");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 41,
                column: "MessageTitleAR",
                value: "انتهت فترة الموافقة علي الخطة");
        }
    }
}
