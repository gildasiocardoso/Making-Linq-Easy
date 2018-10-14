
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBasicsClasses;

namespace MakingLinqEasyMultipleJoin
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FillDataInformation();

        }
        /// <summary>
        /// to fill a recordset to make the test easy
        /// </summary>
        private void FillDataInformation()
        {
            
            // trip 1
            DataModelSample.TRIPRow tr1 = dataModelSample.TRIP.NewTRIPRow();
            tr1.ID_TRIP = 1;
            tr1.NUMBER_OF_PARTICIPANTS = 3;
            tr1.DESTINATION = "Bluffs Beach";
            dataModelSample.TRIP.AddTRIPRow(tr1);

            DataModelSample.PARTICIPANTRow prA1 = dataModelSample.PARTICIPANT.NewPARTICIPANTRow();
            prA1.ID_TRIP = 1;
            prA1.ID_PARTICIPANT = 1;
            prA1.NUMBER_OF_PAYMENTS = 2;
            prA1.NAME_OF_PARTICIPANT = "John Paul";
            dataModelSample.PARTICIPANT.AddPARTICIPANTRow(prA1);
            dataModelSample.PAYMENT.AddPAYMENTRow(10, prA1);
            dataModelSample.PAYMENT.AddPAYMENTRow(20, prA1);


            DataModelSample.PARTICIPANTRow prA2 = dataModelSample.PARTICIPANT.NewPARTICIPANTRow();
            prA2.ID_TRIP = 1;
            prA2.ID_PARTICIPANT = 2;
            prA2.NUMBER_OF_PAYMENTS = 4;
            prA2.NAME_OF_PARTICIPANT = "Gil Cardoso";
            dataModelSample.PARTICIPANT.AddPARTICIPANTRow(prA2);
            dataModelSample.PAYMENT.AddPAYMENTRow(15, prA2);
            dataModelSample.PAYMENT.AddPAYMENTRow(15.01m, prA2);
            dataModelSample.PAYMENT.AddPAYMENTRow(3, prA2);
            dataModelSample.PAYMENT.AddPAYMENTRow(3.01m, prA2);

            DataModelSample.PARTICIPANTRow prA3 = dataModelSample.PARTICIPANT.NewPARTICIPANTRow();
            prA3.ID_TRIP = 1;
            prA3.ID_PARTICIPANT = 3;
            prA3.NUMBER_OF_PAYMENTS = 3;
            prA3.NAME_OF_PARTICIPANT = "David Cash";
            dataModelSample.PARTICIPANT.AddPARTICIPANTRow(prA3);
            dataModelSample.PAYMENT.AddPAYMENTRow(5, prA3);
            dataModelSample.PAYMENT.AddPAYMENTRow(9, prA3);
            dataModelSample.PAYMENT.AddPAYMENTRow(4, prA3);

            // trip 2
            DataModelSample.TRIPRow tr2 = dataModelSample.TRIP.NewTRIPRow();
            tr2.ID_TRIP = 2;
            tr2.NUMBER_OF_PARTICIPANTS = 2;
            tr2.DESTINATION = "Niagara Falls";
            dataModelSample.TRIP.AddTRIPRow(tr2);

            DataModelSample.PARTICIPANTRow prB1 = dataModelSample.PARTICIPANT.NewPARTICIPANTRow();
            prB1.ID_TRIP = 2;
            prB1.ID_PARTICIPANT = 4;
            prB1.NUMBER_OF_PAYMENTS = 2;
            prB1.NAME_OF_PARTICIPANT = "Rajiv Patel";

            dataModelSample.PARTICIPANT.AddPARTICIPANTRow(prB1);
            dataModelSample.PAYMENT.AddPAYMENTRow(8, prB1);
            dataModelSample.PAYMENT.AddPAYMENTRow(6, prB1);


            DataModelSample.PARTICIPANTRow prB2 = dataModelSample.PARTICIPANT.NewPARTICIPANTRow();
            prB2.ID_TRIP = 2;
            prB2.ID_PARTICIPANT = 5;
            prB2.NUMBER_OF_PAYMENTS = 2;
            prB2.NAME_OF_PARTICIPANT = "Eun Jung";
            dataModelSample.PARTICIPANT.AddPARTICIPANTRow(prB2);
            dataModelSample.PAYMENT.AddPAYMENTRow(9.20m, prB2);
            dataModelSample.PAYMENT.AddPAYMENTRow(6.75m, prB2);

            dataModelSample.TRIP.AcceptChanges();
            dataModelSample.PARTICIPANT.AcceptChanges();
            dataModelSample.PAYMENT.AcceptChanges();
            dataModelSample.AcceptChanges();
        }

        /// <summary>
        /// The idea is simple, leave the Group By Clause for the end of process
        /// this makes linq look more like sql command
        /// </summary>
        /// <returns></returns>
        private DataTable JoinThreeTablesWithGroupBy()
        {

            var Query = from join_result in
                                // step 1 part A: doing a join to create a Join Result
                               (from t in dataModelSample.TRIP
                                join pr in dataModelSample.PARTICIPANT on t.ID_TRIP equals pr.ID_TRIP
                                join pm in dataModelSample.PAYMENT on pr.ID_PARTICIPANT equals pm.ID_PARTICIPANT
                                select new
                                {   // step 1 part B: specify here the columns you need
                                    t.ID_TRIP,
                                    t.DESTINATION,
                                    t.NUMBER_OF_PARTICIPANTS,
                                    pm.PAID_VALUE
                                })
                        // step 2 : define fields order
                        orderby join_result.ID_TRIP
                        // step 3 : create your aggregations fields
                        group join_result by new { join_result.ID_TRIP, join_result.DESTINATION }
                        into final_result
                        select new
                        {   // step 4: bring columns from group by using the sintaxe "key"
                            Id_Trip = final_result.Key.ID_TRIP,
                            Destination = final_result.Key.DESTINATION,
                            // step 5 : create your aggregations fields
                            Count_Participant = final_result.Max(r => r.NUMBER_OF_PARTICIPANTS),
                            Total_Trip = final_result.Sum(r => r.PAID_VALUE)
                        };

            DataTable result = new DataTable();
            // CopyToDataTable is a method existent into the namespace MyBasicsClasses, 
            // it implements an extension for DataTables            
            Query.CopyToDataTable(result, null);
            return result;
        }

        /// <summary>
        /// A simple join bringing just the interested fields
        /// </summary>
        /// <returns></returns>
        private DataTable SimpleJoinTables()
        {

            // step 1 : doing a join to create a Join Result
            var Query = from t in dataModelSample.TRIP
                        join pr in dataModelSample.PARTICIPANT on t.ID_TRIP equals pr.ID_TRIP
                        join pm in dataModelSample.PAYMENT on pr.ID_PARTICIPANT equals pm.ID_PARTICIPANT
                        select new
                        {   // step 2 : specify here the columns you need
                            t.ID_TRIP,
                            t.DESTINATION,
                            t.NUMBER_OF_PARTICIPANTS,
                            pm.PAID_VALUE
                        };

            DataTable result = new DataTable();
            // CopyToDataTable is a method existent into the namespace MyBasicsClasses, 
            // it implements an extension for DataTables            
            Query.CopyToDataTable(result, null);
            return result;
        }

        private void btnSimpleJoin_Click(object sender, EventArgs e)
        {
            DataTable dt = SimpleJoinTables();
            dataGridViewLinqResult.DataMember = dt.TableName;
            dataGridViewLinqResult.DataSource = dt;            
        }

        private void btnTripleJoin_Click(object sender, EventArgs e)
        {
            DataTable dt = JoinThreeTablesWithGroupBy();
            dataGridViewLinqResult.DataMember = dt.TableName;
            dataGridViewLinqResult.DataSource = dt;
        }
    }
}
