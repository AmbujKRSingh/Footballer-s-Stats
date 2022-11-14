import { Component, OnInit } from '@angular/core';
import { PlayerDetailService } from 'src/app/shared/player-detail.service';
import { NgForm } from '@angular/forms';
import { PlayerDetail } from 'src/app/shared/player-detail.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-player-detail-form',
  templateUrl: './player-detail-form.component.html',
  styles: [
  ]
})
export class PlayerDetailFormComponent implements OnInit {

  constructor(public service: PlayerDetailService,
    private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm) {
    if (this.service.formData.playerDetailId == 0)
      this.insertRecord(form);
    else
      this.updateRecord(form);
  }

  insertRecord(form: NgForm) {
    this.service.postPlayerDetail().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.success('Submitted successfully', 'Player Detail Register')
      },
      err => { console.log(err); }
    );
  }

  updateRecord(form: NgForm) {
    this.service.putPlayerDetail().subscribe(
      res => {
        this.resetForm(form);
        this.service.refreshList();
        this.toastr.info('Updated successfully', 'Player Detail Register')
      },
      err => { console.log(err); }
    );
  }


  resetForm(form: NgForm) {
    form.form.reset();
    this.service.formData = new PlayerDetail();
  }

}
