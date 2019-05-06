
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, MatTableDataSource } from '@angular/material';
import { Ng2SmartTableModule, LocalDataSource } from 'ng2-smart-table';
import { TasklistService } from './tasklist.service';
import { DatePipe } from '@angular/common';


@Component({
  selector: 'tasklist',
  styleUrls: ['./tasklist.component.css'],
  providers: [DatePipe],
  template: `
  <ng2-smart-table
  [settings]="settings"
  [source]=source
  (deleteConfirm)="onDeleteConfirm($event)"
  (editConfirm)="onSaveConfirm($event)"
  (createConfirm)="onCreateConfirm($event)"></ng2-smart-table>
  `
})



export class TasklistComponent {

  constructor(
    private tasklistService: TasklistService,
    private datePipe: DatePipe) 
  {}

  ngOnInit() {
    this.getData()
  }
  
  source: LocalDataSource;

  settings = {
    columns: {
      Id: {
        title: 'Id'
      },
      Title: {
        title: 'Title'
      },
      Status: {
        title: 'Status'
      },
      CreationDate: {
        title: 'Creation Date',
        type: "date",
        // valuePrepareFunction: (created) => {
        //   return this.datePipe.transform(new Date(created), 'dd MMM yyyy');
        // }
      },
      LastEdit: {
        title: 'Edit On',
        type: "date",
        // valuePrepareFunction: (created) => {
        //   return this.datePipe.transform(new Date(created), 'dd MMM yyyy');
        // }
    
      },
      Conclusion: {
        title: 'Conclusion',
        type: "date",
        // valuePrepareFunction: (created) => {
        //   return this.datePipe.transform(new Date(created), 'dd MMM yyyy');
        // }
 
      }
      
    },
    actions: {
        position: 'right',
    },
    delete: {
      confirmDelete: true
    },
    add: {
      confirmCreate: true
    },
    edit: {
      confirmSave: true
    },
    filter: {
      disable: true
    }
  };

  

  // // data = [
  // //   {
  // //     title: "Task1",
  // //     status: "done",
  // //     creationdate: "2012-12-25",
  // //     lastedit: "2012-12-25",
  // //     conclusion: "2012-12-25"
  // //   },
  // // ];

  getData() {
    debugger;
    var arrayDt;

    this.source = new LocalDataSource();

    this.tasklistService.gettasks().subscribe((data) =>
    {

      for(let i=0; i < data.Tasklist.length; i++) {  
        data.Tasklist[i].CreationDate = data.Tasklist[i].CreationDate.replace(/T.*$/,"");
        data.Tasklist[i].LastEdit = data.Tasklist[i].LastEdit.replace(/T.*$/,"");
        data.Tasklist[i].Conclusion = data.Tasklist[i].Conclusion.replace(/T.*$/,"");
        data.Tasklist[i].RemovedOn = data.Tasklist[i].RemovedOn.replace(/T.*$/,"");
      }

      // // this.data.push(
      // //   {
      // //     title: "Task3",
      // //     status: "done",
      // //     creationdate: "2012-12-25",
      // //     lastedit: "2012-12-25",
      // //     conclusion: "2012-12-25"
      // //   },
      // // );

      this.source.load(data.Tasklist);

    });
  }

  onDeleteConfirm(event) {
    if (window.confirm('Are you sure you want to delete?')) {
      this.tasklistService.deletetask(event.data).subscribe();
      event.confirm.resolve();
    } else {
      event.confirm.reject();
    }
  }

  onSaveConfirm(event) {
    if (window.confirm('Are you sure you want to save?')) {
      this.tasklistService.updatetask(event.newData).subscribe();
      event.confirm.resolve(event.newData);
    } else {
      event.confirm.reject();
    }
  }

  onCreateConfirm(event) {
    if (window.confirm('Are you sure you want to create?')) {
      debugger
      this.tasklistService.addtask(event.newData).subscribe();
      event.confirm.resolve(event.newData);
    } else {
      event.confirm.reject();
    }
  }


}