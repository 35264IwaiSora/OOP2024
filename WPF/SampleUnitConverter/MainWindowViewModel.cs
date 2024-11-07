using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel{
        private double metricValue , imperialValue;

        //▲buttonで呼ばれるコマンド
        public ICommand ImperialUnitToMetric {  get; private set; }
        //▼buttonで呼ばれるコマンド
        public ICommand MetricToImperialUnit { get; private set; }

        //上のコンボボックスで選択されている値
        public MetricUnit CurrentMetricUnit { get; set; }
        //下のコンボボックスで選択されている値
        public ImperialUnit CurrentImperialUnit { get; set; }

        public double MetricValue {
            get { return metricValue; }
            set { metricValue = value;
            OnPropertyChanged();
            }
                
        }
        public double ImperialValue {
            get { return imperialValue; }
            set { imperialValue = value;
                OnPropertyChanged();
            }
        }

        //コンストラクタ
        public MainWindowViewModel(){
            CurrentMetricUnit = MetricUnit.Units.First();
            CurrentImperialUnit = ImperialUnit.Units.First();

            MetricToImperialUnit = new DelegateCommand(() => 
                        ImperialValue = CurrentImperialUnit.FromMetricUnit(CurrentMetricUnit,MetricValue));


            ImperialUnitToMetric = new DelegateCommand(() =>
                        MetricValue = CurrentMetricUnit.FromImperialUnit(CurrentImperialUnit, ImperialValue));
        }
    }
}