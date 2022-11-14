import { Component, OnInit } from '@angular/core';
import { PlayerDetailService } from '../shared/player-detail.service';
import { PlayerDetail } from '../shared/player-detail.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-player-details',
  templateUrl: './player-details.component.html',
  styles: [
  ]
})
export class PlayerDetailsComponent implements OnInit {

  constructor(public service: PlayerDetailService,
    private toastr: ToastrService) { }

  ngOnInit(): void {
    this.service.refreshList();
  }

  populateForm(selectedRecord: PlayerDetail) {
    this.service.formData = Object.assign({}, selectedRecord);
  }

  onDelete(id: number) {
    if (confirm('Are you sure to delete this record?')) {
      this.service.deletePlayerDetail(id)
        .subscribe(
          res => {
            this.service.refreshList();
            this.toastr.error("Deleted successfully", 'Player Detail Register');
          },
          err => { console.log(err) }
        )
    }
  }

}
