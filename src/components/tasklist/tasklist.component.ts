
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

  ngAfterContentInit() {
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
        type: "date"
      },
      LastEdit: {
        title: 'Edit On',
        type: "date"

    
      },
      Conclusion: {
        title: 'Conclusion',
        type: "date"

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

  


  getData() {
    this.source = new LocalDataSource();

    this.tasklistService.gettasks().subscribe((data) =>
    {

      data.Tasklist.forEach(x => {
        x.CreationDate = x.CreationDate.replace(/T.*$/,"");
        x.LastEdit = x.LastEdit.replace(/T.*$/,"");
        x.Conclusion = x.Conclusion.replace(/T.*$/,"");
        x.RemovedOn = x.RemovedOn.replace(/T.*$/,"");
      });

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
      this.tasklistService.addtask(event.newData).subscribe();
      event.confirm.resolve(event.newData);
    } else {
      event.confirm.reject();
    }
  }


}