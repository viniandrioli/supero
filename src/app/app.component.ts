
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, MatTableDataSource } from '@angular/material';
import { Ng2SmartTableModule } from 'ng2-smart-table';
import { AppService } from './app.service';
import { DatePipe } from '@angular/common';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [DatePipe],
  template: `
  <ng2-smart-table
  [settings]="settings"
  [source]="data"
  (deleteConfirm)="onDeleteConfirm($event)"
  (editConfirm)="onSaveConfirm($event)"
  (createConfirm)="onCreateConfirm($event)"></ng2-smart-table>
  `
})



export class AppComponent {

  constructor(
    private appService: AppService,
    private datePipe: DatePipe) 
  {}

  ngOnInit() {

  }
   

  settings = {
    columns: {
      id: {
        title: 'id'
      },
      title: {
        title: 'Title'
      },
      status: {
        title: 'Status'
      },
      creationdate: {
        title: 'Creation Date',
        valuePrepareFunction: (created) => {
          return this.datePipe.transform(new Date(created), 'dd MMM yyyy');
        }
      },
      lastedit: {
        title: 'Edit On',
        valuePrepareFunction: (created) => {
          return this.datePipe.transform(new Date(created), 'dd MMM yyyy');
        }
    
      },
      conclusion: {
        title: 'Conclusion',
        valuePrepareFunction: (created) => {
          return this.datePipe.transform(new Date(created), 'dd MMM yyyy');
        }
 
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

  

  data = [
    {
      title: "Task1",
      status: "done",
      creationdate: "2012-12-25",
      lastedit: "2012-12-25",
      conclusion: "2012-12-25"
    },
    {
      title: "Task2",
      status: "done",
      creationdate: "2012-12-25",
      lastedit: "2012-12-25",
      conclusion: "2012-12-25"
    },
       
    {
      title: "Task3",
      status: "done",
      creationdate: "2012-12-25",
      lastedit: "2012-12-25",
      conclusion: "2012-12-25"
    }
  ];

  onDeleteConfirm(event) {
    if (window.confirm('Are you sure you want to delete?')) {
      this.appService.deletetask(event.data).subscribe();
      event.confirm.resolve();
    } else {
      event.confirm.reject();
    }
  }

  onSaveConfirm(event) {
    if (window.confirm('Are you sure you want to save?')) {
      this.appService.updatetask(event.newData).subscribe();
      event.confirm.resolve(event.newData);
    } else {
      event.confirm.reject();
    }
  }

  onCreateConfirm(event) {
    if (window.confirm('Are you sure you want to create?')) {
      debugger
      this.appService.addtask(event.newData).subscribe();
      event.confirm.resolve(event.newData);
    } else {
      event.confirm.reject();
    }
  }


}