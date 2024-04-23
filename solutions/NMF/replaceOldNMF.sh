find ./OutagePrevention -name "*.cs" -exec sed -i '1i using System.Collections.Specialized;' {} +
find ./OutagePrevention -name "*.cs" -exec sed -i 's/NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs/NotifyCollectionChangedEventArgs/g' {} +
